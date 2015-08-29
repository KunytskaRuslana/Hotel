using Hotel.Entity;
using Hotel.Repositories;
using Hotel.Repositories.Sql;
using Hotel.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Configuration;
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
        string queryGetAllId = "SELECT [dbo].[tblTypeRooms].[Id], [dbo].[tblTypeRooms].[Name], [dbo].[tblDescriptionRoom].[Price]"
                             + "FROM [dbo].[tblTypeRooms]"
                             + "JOIN [dbo].[tblDescriptionRoom] ON [dbo].[tblDescriptionRoom].[TypeRoomId] = [dbo].[tblTypeRooms].[Id]"
                             + "WHERE [dbo].[tblDescriptionRoom].[Id] = @Id";
        
        public string DoWork()
        {
            return "Hello";
        }

        public RoomDTO[] SelectAll()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectToSQL"].ConnectionString;
            IRoomRepository repository = new RoomRepository(connectionString);

            var rooms = repository.SelectAll();

            var roomDTOs = new List<RoomDTO>();

            foreach (var room in rooms)
            {
                roomDTOs.Add(new RoomDTO() { npp = room.npp, Id = room.Id, Name = room.Name, Price = room.Price });
            }

            return roomDTOs.ToArray();
        }
 
        public void BrokedRoom(BrokedRoomDTO room)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectToSQL"].ConnectionString;
                IRoomRepository repository = new RoomRepository(connectionString);

                NewRoom newRoom = new NewRoom();
                newRoom.Fio = room.Fio;
                newRoom.NumberPhone = room.NumberPhone;
                newRoom.Email = room.Email;
                newRoom.DescriptionRommId = room.DescriptionRommId;
                newRoom.DateFrom = room.DateFrom;
                newRoom.DateTo = room.DateTo;
                newRoom.Reserve = room.Reserve;

                repository.BrokedRoom(newRoom);

            }
            catch (Exception e)
            {
                Exception baseException = e.GetBaseException();
                throw new FaultException(e.Message);
            }
        }

        public int GetId(int numRecord)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectToSQL"].ConnectionString;
            IRoomRepository repository = new RoomRepository(connectionString);

            int _id = 0;
            int counter = 0;

            var rooms = repository.SelectAll();

            var roomDTOs = new List<RoomDTO>();

            foreach (var room in rooms)
            {
                counter++;
                roomDTOs.Add(new RoomDTO() { Id = room.Id, Name = room.Name, Price = room.Price, npp =  counter});
            }

            foreach (var item in roomDTOs)
            {
                if (item.npp == numRecord)
                {
                    _id = item.Id;
                    break;
                }
            }

            return _id;
        }

        public RoomDTO GetRowById(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectToSQL"].ConnectionString;
            IRoomRepository repository = new RoomRepository(connectionString);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(queryGetAllId, connection))
                {
                    command.Parameters.AddWithValue("id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        RoomDTO room = new RoomDTO();
                        if (reader.Read())
                        {
                            room = (new RoomDTO()
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
    }
}
