﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.Entity
{
    [Table("tUser")]
    public partial class User
    {

        bool text = true;
        User() {
            this.UserInRole = new HashSet<UserInRole>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("cId")]
        public int Id { get; set; }
        public virtual ICollection<UserInRole> UserInRole { get; set; }

    }
}
