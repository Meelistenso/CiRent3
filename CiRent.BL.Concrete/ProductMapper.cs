using CiRent.BL.Entities;
using CiRent.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.BL.Concrete
{
    public class ProductMapper
    {
        public ProductModel EntityToModel(Product entity)
        {
            ProductModel res = new ProductModel();
                res.Description = entity.Description;
                res.BigPrice = (int)entity.Price;
                res.SmallPrice = (int)(entity.Price - res.BigPrice) * res.BigPrice.ToString().Length;
                res.NameOfItem = entity.Name;
                res.PhotoPath = entity.PhotoPath;
            return res;
        }
    }
}
