using Hotel.Entity;
using Hotel.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Hotel.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHotelService" in both code and config file together.
    [ServiceContract]
    public interface IHotelService
    {
        [OperationContract]
        string DoWork();

        [OperationContract]       
        RoomDTO[] SelectAll();

        [OperationContract]
        [FaultContract(typeof(string))]
        void BrokedRoom(BrokedRoomDTO room);

        [OperationContract]
        int GetId(int numRecord);

        [OperationContract]
        RoomDTO GetRowById(int id);

        //[OperationContract]
        //NewRoom AddRecord(NewRoom newRoom);
    }
}
