using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.BL.Entities
{
    public class ProductsModel
    {
        //category model for items
        public string PhotoPath { get; set; }
        public int IdOfItem { get; set; }
        public string NameOfItem { get; set; }
        public int BigPrice { get; set; }
        public int SmallPrice { get; set; }
    }
}
