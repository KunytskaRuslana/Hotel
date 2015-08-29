using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Hotel.Service.DTOs
{
    [DataContract]
    public class RoomDTO
    {
        [DataMember]
        public int npp { get; set; }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Price { get; set; }
    }
}