using CiRent.BL.Entities;
using CiRent.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.BL.Concrete
{
    public class ProductCategoryMapper
    {
        public ProductCategoryModel EntityToModel(Category entity, List<Product> entity2)
        {
            ProductCategoryModel res = new ProductCategoryModel();
            SidebarCategoriesMapper mapper2 = new SidebarCategoriesMapper();
            ProductsMapper mapper = new ProductsMapper();
            res.Category = mapper2.EntityToModel(entity);
            res.Items = mapper.EntityToModel(entity2);
            return res;
        }
    }
}
