using Hotel.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Hotel.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HotelService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HotelService.svc or HotelService.svc.cs at the Solution Explorer and start debugging.
    public class HotelService : IHotelService
    {
        string querySelect = "SELECT [dbo].[tblDescriptionRoom].[Id], [dbo].[tblTypeRooms].[Name], [dbo].[tblDescriptionRoom].[Price]"
                           + "FROM [dbo].[tblTypeRooms]"
                           + "JOIN [dbo].[tblDescriptionRoom] ON [dbo].[tblDescriptionRoom].[TypeRoomId] = [dbo].[tblTypeRooms].[Id]";
        string queryGetAllId = "SELECT [dbo].[tblTypeRooms].[Id], [dbo].[tblTypeRooms].[Name], [dbo].[tblDescriptionRoom].[Price]"
                             + "FROM [dbo].[tblTypeRooms]"
                             + "JOIN [dbo].[tblDescriptionRoom] ON [dbo].[tblDescriptionRoom].[TypeRoomId] = [dbo].[tblTypeRooms].[Id]"
                             + "WHERE [dbo].[tblDescriptionRoom].[Id] = @Id";
        string queryInsert = "INSERT INTO [dbo].[tblBrokedRoom] ([Fio],[NumberPhone],[Email],[DescriptionRommId],[DateFrom],[DateTo],[Reserve]) VALUES (@Fio,@NumberPhone,@Email,@DescriptionRommId,@DateFrom,@DateTo,@Reserve); SELECT CAST(SCOPE_IDENTITY() AS INT);";
        string connectionString = "Server=RUSLANA-ПК;DataBase=HotelUkraine;User=sa;password=19999";

        public List<Room> SelectAll()
        {
            int counter = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(querySelect, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Room> product = new List<Room>();
                        while (reader.Read())
                        {
                            counter++;
                            product.Add(new Room()
                            {
                                npp = counter,
                                Id = (int)reader["id"],
                                Name = (string)reader["Name"],
                                Price = (int)reader["Price"]
                            });
                        }
                        return product;
                    }
                }
            }
        }
        
        public NewRoom AddRecord(NewRoom newRoom)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(queryInsert, connection))
                {
                    command.Parameters.AddWithValue("Fio", newRoom.Fio);
                    command.Parameters.AddWithValue("NumberPhone", newRoom.NumberPhone);
                    command.Parameters.AddWithValue("Email", newRoom.Email);
                    command.Parameters.AddWithValue("DescriptionRommId", newRoom.DescriptionRommId);
                    command.Parameters.AddWithValue("DateFrom", Convert.ToDateTime(newRoom.DateFrom));
                    command.Parameters.AddWithValue("DateTo", Convert.ToDateTime(newRoom.DateTo));
                    command.Parameters.AddWithValue("Reserve", newRoom.Reserve);

                    int connectId = (int)command.ExecuteScalar();
                    newRoom.Id = connectId;

                    return newRoom;
                }
            }
        }

        public int GetId(int numRecord)
        {
            int _id = 0;
            int counter = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(querySelect, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Room> room = new List<Room>();
                        while (reader.Read())
                        {
                            counter++;
                            room.Add(new Room()
                            {
                                Id = (int)reader["id"],
                                Name = (string)reader["Name"],
                                Price = (int)reader["Price"],
                                npp = counter
                            });
                        }

                        foreach (var item in room)
                        {
                            if (item.npp == numRecord)
                            {
                                _id = item.Id;
                                break;
                            }
                        }

                        return _id;
                    }
                }
            }
        }

        public Room GetRowById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(queryGetAllId, connection))
                {
                    command.Parameters.AddWithValue("id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Room room = new Room();
                        if (reader.Read())
                        {
                            room = (new Room()
                            {
                                Id = (int)reader["id"],
                                Name = (string)reader["Name"],
                                Price = (int)reader["Price"]
                            });
                            return room;
                        }
                        else
                        {
                            return null;
                        }

                    }
                }
            }
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
