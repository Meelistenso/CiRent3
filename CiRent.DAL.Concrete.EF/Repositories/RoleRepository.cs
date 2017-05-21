using System;
using CiRent.DAL.Abstract;
using CiRent.DAL.Abstract.IRepositories;
using CiRent.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.DAL.Concrete.EF.Repositories
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        public RoleRepository(ICiRentContext context) : base(context)
        {

        }
    }
}
