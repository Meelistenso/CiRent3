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
        public List<ProductsModel> EntityToModel(List<Product> entity,int id)
        {
            List<ProductsModel> p = new List<ProductsModel>();
            foreach (var item in entity)
            {
                ProductsModel pm = new ProductsModel();
                pm.Id = id;
                    pm.BigPrice = (int)item.Price;
                    pm.SmallPrice = (int)(((item.Price)- pm.BigPrice) *100);
                    pm.PhotoPath = item.PhotoPath;
                    pm.NameOfItem = item.Name;
                    pm.IdOfItem = item.Id;
                p.Add(pm);
            }
            return p;
        }
        public List<ProductsModel> EntityToModel(List<Category> entity,int id)
        {
            List<ProductsModel> p = new List<ProductsModel>();
            foreach (var item in entity)
            {
                foreach (var item2 in item.Products)
                {
                    ProductsModel pm = new ProductsModel();
                    pm.Id = id;
                    pm.BigPrice = (int)item2.Price;
                    pm.SmallPrice = (int)(((item2.Price) - pm.BigPrice) * 100);
                    pm.PhotoPath = item2.PhotoPath;
                    pm.NameOfItem = item2.Name;
                    pm.IdOfItem = item2.Id;
                    p.Add(pm);
                }
            }
            return p;
        }
        public List<ProductsModel> EntityToModel(List<Product> entity)
        {
            List<ProductsModel> p = new List<ProductsModel>();
            foreach (var item in entity)
            {
                ProductsModel pm = new ProductsModel();
                pm.BigPrice = (int)item.Price;
                pm.SmallPrice = (int)(((item.Price) - pm.BigPrice) * 100);
                pm.PhotoPath = item.PhotoPath;
                pm.NameOfItem = item.Name;
                pm.IdOfItem = item.Id;
                p.Add(pm);
            }
            return p;
        }
    }
}
