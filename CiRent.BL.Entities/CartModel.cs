using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.BL.Entities
{
    public class CartModel
    {
        public decimal TotalPrice { get; set; }
        public List<CartsModel> CartsModel { get; set; }
    }
}
