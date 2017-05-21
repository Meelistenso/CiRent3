
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.Entity
{

    [Table("tCategory")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("cId")]
        public int Id { get; set; }
        [Column("cPhotoPath")]
        public string PhotoPath { get; set; }
        [Column("cName")]
        public string Name { get; set; }
        
        [Column("cParentId")]
        public int? ParentId { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        [ForeignKey("ParentId")]
        public virtual Category Parent { get; set; }
        public virtual ICollection<Category> Child { get; set; }
    }
}
