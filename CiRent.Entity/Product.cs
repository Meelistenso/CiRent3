using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.Entity
{
    [Table("tProduct")]
    public class Product
    {
        public Product()
        {
            ProductTypes = new HashSet<ProductType>();
            ProductInOrders = new HashSet<ProductInOrder>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("cId")]
        public int Id { get; set; }

        [Column("cPrice")]
        public decimal Price { get; set; }
        [Column("cProductQuantity")]
        public int ProductQuantity { get; set; }
        public virtual ICollection<ProductType> ProductTypes { get; set; }
        public virtual ICollection<ProductInOrder> ProductInOrders { get; set; }
    }
}
