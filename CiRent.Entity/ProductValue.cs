using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.Entity
{
    [Table("tProductValue")]
    public class ProductValue
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("cId")]
        public int Id { get; set; }

        [Column("cIdParam")]
        public int IdParam { get; set; }
        [ForeignKey("IdParam")]
        public virtual ParamDictionary Param { get; set; }

        [Column("cIdProductType")]
        public int IdProductType { get; set; }
        [ForeignKey("IdProductType")]
        public virtual ProductType ProductType { get; set; }

        [Column("cValue")]
        public string Value { get; set; }
    }
}
