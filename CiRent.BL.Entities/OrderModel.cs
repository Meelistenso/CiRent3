using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.BL.Entities
{
    public class OrderModel
    {
        public decimal TotalPrice { get; set; }
        public string State { get; set; }
        public DateTime Date{ get; set; }
        public int TotalItems { get; set; }
        public List<OrdersModel> OrdersModel { get; set; }
    }
}
