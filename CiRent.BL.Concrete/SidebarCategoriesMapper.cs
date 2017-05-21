using CiRent.BL.Entities;
using CiRent.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.BL.Concrete
{
    public class SidebarCategoriesMapper
    {
        public List<SidebarCategoriesModel> EntityToModel(Category entity)
        {
            List<SidebarCategoriesModel> res = new List<SidebarCategoriesModel>();
            foreach (var item in entity.Products)
            {
                    SidebarCategoriesModel c = new SidebarCategoriesModel();
                    c.Id = item.Id;
                    c.Name = item.Name;
                    res.Add(c);
            }
            return res;
        }
    }
}
