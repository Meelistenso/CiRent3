using CiRent.BL.Entities;
using System;
using CiRent.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.BL.Concrete
{
    public class CartMapper 
    {
        public CartModel EntityToModel(List<Order> entity)
        {
            CartModel c = new CartModel();
            CartsMapper mapper = new CartsMapper();
            c.CartsModel = mapper.
            c.TotalPrice = c.CartsModel.Sum(p=>p.Price);
            return res;
        }
    }
}
