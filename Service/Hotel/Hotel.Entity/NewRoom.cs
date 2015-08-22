using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Entity
{ 
    public class NewRoom
    {
        public int Id { get; set; }
        public string Fio { get; set; }
        public string NumberPhone { get; set; }
        public string Email { get; set; }
        public int DescriptionRommId { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public int Reserve { get; set; }
    }
}
