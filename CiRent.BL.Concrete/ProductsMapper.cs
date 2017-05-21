using CiRent.BL.Entities;
using CiRent.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.BL.Concrete
{
    public class ProductsMapper
    {
        public List<ProductsModel> EntityToModel(List<Product> entity)
        {
            List<ProductsModel> p = new List<ProductsModel>();
            foreach (var item in entity)
            {
                ProductsModel pm = new ProductsModel();
                    pm.BigPrice = (int)item.Price;
                    pm.SmallPrice = (int)(item.Price - pm.BigPrice) * pm.BigPrice.ToString().Length;
                    pm.PhotoPath = item.PhotoPath;
                    pm.NameOfItem = item.Name;
                    pm.IdOfItem = item.Id;
                p.Add(pm);
            }
            return p;
        }
    }
}
