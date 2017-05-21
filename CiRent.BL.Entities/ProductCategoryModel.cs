using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.BL.Entities
{
    public class ProductCategoryModel
    {
        public List<SidebarCategoriesModel> Category { get; set; }
        public List<ProductsModel> Items { get; set; }
    }
}
