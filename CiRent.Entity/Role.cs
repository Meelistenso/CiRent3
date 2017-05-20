﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.Entity
{
    public class Role : IdentityRole
    {
        public Role() { }

        public int RoleDetailsId { get; set; }
        public string Description { get; set; }
    }
}
