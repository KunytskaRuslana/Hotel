using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Hotel.Service.DTOs
{
    [DataContract]
    public class BrokedRoomDTO
    {
        [DataMember]
        public string Fio { get; set; }

        [DataMember]
        public string NumberPhone { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public int DescriptionRommId { get; set; }

        [DataMember]
        public string DateFrom { get; set; }

        [DataMember]
        public string DateTo { get; set; }

        [DataMember]
        public int Reserve { get; set; }
    }
}