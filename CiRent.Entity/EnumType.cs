using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.Entity
{
    [Table("tEnumType")]
    public class EnumType
    {
        public EnumType()
        {
            EnumValues = new HashSet<EnumValue>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("cId")]
        public int Id { get; set; }

        [Column("cProductTypeValue")]
        public string TypeName { get; set; }
        public virtual ICollection<EnumValue> EnumValues { get; set; }
        public  virtual Category Category { get; set; }
    }
}
