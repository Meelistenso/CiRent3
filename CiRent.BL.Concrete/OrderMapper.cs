using CiRent.BL.Entities;
using CiRent.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.BL.Concrete
{
    public class OrderMapper
    {
        public List<OrderModel> EntityToModel(List<Order> entity)
        {
            List<OrderModel> res = new List<OrderModel>();
            OrdersMapper mapper = new OrdersMapper();
            foreach (var item in entity) {
                OrderModel c = new OrderModel();
                c.OrdersModel = mapper.EntityToModel(item.ProductsInOrder.ToList());
                c.TotalPrice = item.TotalPrice;
                c.State = item.State;
                c.TotalItems = c.OrdersModel.Count();
            }
            return res;
        }
    }
}
