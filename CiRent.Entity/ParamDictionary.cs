
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.Entity
{

    [Table("tParamDictionary")]
    public class ParamDictionary
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("cId")]
        public int Id { get; set; }

        [Column("cName")]
        public string Name { get; set; }

        [Column("cIdType")]
        public int IdType { get; set; }
        [ForeignKey("IdType")]
        public virtual ProductTypeDictionary ProductTypeDictionary { get; set; }

        [Column("cChildId")]
        public int ParamId { get; set; }
        [ForeignKey("ParamId")]
        public virtual ICollection<ParamDictionary> Child { get; set; }
    }
}
