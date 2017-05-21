using CiRent.BL.Entities;
using CiRent.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.BL.Concrete
{
    public class MainPageCategoryMapper
    {
        public List<MainPageCategoryModel> EntityToModel(List<Category> entity)
        {
            List<MainPageCategoryModel> res = new List<MainPageCategoryModel>();
            foreach (var item in entity)
            {
                if (item.Parent==null) {
                    MainPageCategoryModel c = new MainPageCategoryModel();
                    c.IdOfCategory = item.Id;
                    c.NameOfCategory = item.Name;
                    c.PhotoPath = item.PhotoPath;
                    res.Add(c);
                }
            }
            return res;
        }
    }
}
