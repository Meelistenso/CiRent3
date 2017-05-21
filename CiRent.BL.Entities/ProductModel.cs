using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.BL.Entities
{
    public class ProductModel
    {
        public string PhotoPath { get; set; }
        public string NameOfItem { get; set; }
        public string Description { get; set; }
        public int BigPrice { get; set; }
        public int SmallPrice { get; set; }
    }
}
