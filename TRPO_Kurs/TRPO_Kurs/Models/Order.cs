using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TRPO_Kurs.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int EquipmentId { get; set; }
        public DateTime DataTime { get; set; }
        public string Email { get; set; }
        public string FIO { get; set; }
        public string Address { get; set; }
        public int Amount { get; set; }
    }
}