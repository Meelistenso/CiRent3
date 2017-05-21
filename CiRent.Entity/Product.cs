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
            ProductInOrders = new HashSet<ProductsInOrder>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("cId")]
        public int Id { get; set; }

        [Column("cPrice")]
        public decimal Price { get; set; }
        [Column("cProductQuantity")]
        public int ProductQuantity { get; set; }

        [Column("сPhotoPath")]
        public string PhotoPath { get; set; }

        [Column("cDescription")]
        public string Description { get; set; }

        [Column("cName")]
        public string Name { get; set; }

        public int IdCategory { get; set; }
        [ForeignKey("IdCategory")]
        public virtual Category Category { get; set; }
        public virtual EnumValue EnumValue { get;  set; }
        public virtual ICollection<ProductsInOrder> ProductInOrders { get; set; }
    }
}
