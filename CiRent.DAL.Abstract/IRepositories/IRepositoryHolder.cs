using CiRent.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CiRent.Entity;

namespace CiRent.DAL.Abstract.IRepositories
{
    public interface IRepositoryHolder
    {
        ICiRentContext Context { get; }
        IProductRepository ProductRepository { get; }
        IUserRepository UserRepository { get; }
        IRoleRepository RoleRepository { get; }
        IOrderRepository OrderRepository { get; }
        IProductInOrderRepository ProductInOrderRepository { get; }
        ICategoryRepository CategoryRepository { get; }

        void SaveChanges();

    }
}
