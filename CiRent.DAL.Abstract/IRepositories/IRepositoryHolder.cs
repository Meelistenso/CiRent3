using CiRent.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.DAL.Abstract.IRepositories
{
    public interface IRepositoryHolder
    {
        ICiRentContext Context { get; }
        IProductRepository ProductRepository { get; }
        void SaveChanges();
    }
}
