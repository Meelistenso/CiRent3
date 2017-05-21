using CiRent.DAL.Abstract;
using CiRent.DAL.Abstract.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.DAL.Concrete.EF.Repositories
{
    public class RepositoryHolder : IRepositoryHolder
    {
        CiRent.DAL.Abstract.ICiRentContext _context;
        IProductRepository _productrepository;
        public RepositoryHolder()
        {
            _context = new CiRentContext();
        }
        public ICiRentContext Context
        {
            get
            {
                return _context;
            }

        }
        public IProductRepository ProductRepository
        {
            get
            {
                if (_productrepository == null)
                    _productrepository = new ProductRepository(_context);
                return _productrepository;
            }
        }
       
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            if (_productrepository != null)
            {
                _productrepository.Dispose();
            }

        }
    }
}
