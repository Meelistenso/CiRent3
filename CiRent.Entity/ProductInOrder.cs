using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.Entity
{
    [Table("tProductInOrder")]
    public class ProductInOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("cId")]
        public int Id { get; set; }

        [Column("cIdProduct")]
        public int IdProduct { get; set; }
        [ForeignKey("IdProduct")]
        public virtual Product Product { get; set; }

        [Column("cPrice")]
        public decimal Price { get; set; }

        [Column("cRentBeginnig")]
        public DateTime RentBeginning{get;set;}

        [Column("cRentEnding")]
        public DateTime RentEnding { get; set; }

        [Column("cIdOrder")]
        public int IdOrder { get; set; }
        [ForeignKey("IdOrder")]
        public virtual Order Order { get; set; }
    }
}
