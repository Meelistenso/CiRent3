using CiRent.DAL.Concrete.EF;
using CiRent.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.IDEntity
{

    public class ApplicationRoleManager : RoleManager<Role>
    {

        public ApplicationRoleManager(RoleStore<Role> store)
                    : base(store)
        { }
        public static ApplicationRoleManager Create(IdentityFactoryOptions<ApplicationRoleManager> options,
                                                IOwinContext context)
        {
            return new ApplicationRoleManager(new
                    RoleStore<Role>(context.Get<CiRentContext>()));
        }

    }
}
