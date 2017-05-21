using CiRent.BL.Entities;
using CiRent.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.BL.Concrete
{
    public class CartsMapper
    {
        public List<CartsModel> EntityToModel(List<Order> entity)
        {
            List<CartsModel> res = new List<CartsModel>();
            foreach (var item in entity)
            {
                CartsModel c = new CartsModel();
                c.Id = item.Id;
                
            }
            return res;
        }
    }
}
