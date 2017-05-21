using CiRent.BL.Entities;
using CiRent.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.BL.Concrete
{
    public class OrdersMapper
    {
        public List<OrdersModel> EntityToModel(List<ProductsInOrder> entity)
        {
            List<OrdersModel> res = new List<OrdersModel>();
            foreach (var item in entity)
            {
                OrdersModel c = new OrdersModel();
                c.Id = item.Id;
                c.PhotoPath = item.Product.PhotoPath;
                c.Price = item.Product.Price;
                c.ProductName = item.Product.Name;
                c.StartDate = item.RentBeginning;
                c.EndDate = item.RentEnding;

            }
            return res;
        }
    }
}
