using Hotel.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repositories.Sql
{
    public class RoomRepository : IRoomRepository
    {
        #region Queries

        private const string querySelect = "SELECT [dbo].[tblDescriptionRoom].[Id], [dbo].[tblTypeRooms].[Name], [dbo].[tblDescriptionRoom].[Price]"
                           + "FROM [dbo].[tblTypeRooms]"
                           + "JOIN [dbo].[tblDescriptionRoom] ON [dbo].[tblDescriptionRoom].[TypeRoomId] = [dbo].[tblTypeRooms].[Id]";
        private const string queryGetAllId = "SELECT [dbo].[tblTypeRooms].[Id], [dbo].[tblTypeRooms].[Name], [dbo].[tblDescriptionRoom].[Price]"
                             + "FROM [dbo].[tblTypeRooms]"
                             + "JOIN [dbo].[tblDescriptionRoom] ON [dbo].[tblDescriptionRoom].[TypeRoomId] = [dbo].[tblTypeRooms].[Id]"
                             + "WHERE [dbo].[tblDescriptionRoom].[Id] = @Id";
        private const string queryInsert = "INSERT INTO [dbo].[tblBrokedRoom] ([Fio],[NumberPhone],[Email],[DescriptionRommId],[DateFrom],[DateTo],[Reserve]) VALUES (@Fio,@NumberPhone,@Email,@DescriptionRommId,@DateFrom,@DateTo,@Reserve); SELECT CAST(SCOPE_IDENTITY() AS INT);";

        #endregion


        #region Fileds

        private readonly string _connectionString;

        #endregion

        #region Constructors

        public RoomRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }

        #endregion

        #region IRoomRepository

        public List<Room> SelectAll()
        {
            int counter = 0;
            using (SqlConnection connection = new SqlConnection(this._connectionString))
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
                                npp = counter,
                                Id = (int)reader["id"],
                                Name = (string)reader["Name"],
                                Price = (int)reader["Price"]
                            });
                        }
                        return room;
                    }
                }
            }
        }

        public NewRoom AddRecord(NewRoom newRoom)
        {
            using (SqlConnection connection = new SqlConnection(this._connectionString))
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
            using (SqlConnection connection = new SqlConnection(this._connectionString))
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
            using (SqlConnection connection = new SqlConnection(this._connectionString))
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

        public void BrokedRoom(NewRoom newRoom)
        {
            using (var connection = new SqlConnection(this._connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "procBrokedRoom";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Fio", newRoom.Fio);
                    command.Parameters.AddWithValue("@NumberPhone", newRoom.NumberPhone);
                    command.Parameters.AddWithValue("@Email", newRoom.Email);
                    command.Parameters.AddWithValue("@DescriptionRoomId", newRoom.DescriptionRommId);
                    command.Parameters.AddWithValue("@DateFrom", Convert.ToDateTime(newRoom.DateFrom));
                    command.Parameters.AddWithValue("@DateTo", Convert.ToDateTime(newRoom.DateTo));
                    command.Parameters.AddWithValue("@Reserve", newRoom.Reserve);

                    command.ExecuteNonQuery();
                }
            }

        }

        #endregion
    }
}
