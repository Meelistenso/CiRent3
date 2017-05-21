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
        IProductRepository _productRepository;
        IUserRepository _userRepository;
        IRoleRepository _roleRepository;
        IOrderRepository _orderRepository;
        IProductInOrderRepository _productInOrderRepository;
        ICategoryRepository _categoryRepository;

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
                if (_productRepository == null)
                    _productRepository = new ProductRepository(_context);
                return _productRepository;
            }
        }
        public ICategoryRepository CategoryRepository
        {
            get
            {
                if (_categoryRepository == null)
                    _categoryRepository = new CategoryRepository(_context);
                return _categoryRepository;
            }
        }
        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(_context);
                return _userRepository;
            }
        }
        public IRoleRepository RoleRepository
        {
            get 
            {
                if (_roleRepository == null)
                    _roleRepository = new RoleRepository(_context);
                return _roleRepository;
            }
        }
        public IOrderRepository OrderRepository
        {
            get
            {
                if (_orderRepository == null)
                    _orderRepository = new OrderRepository(_context);
                return _orderRepository;
            }
        }
        public IProductInOrderRepository ProductInOrderRepository
        {
            get
            {
                if (_productInOrderRepository == null)
                    _productInOrderRepository = new ProductInOrderRepository(_context);
                return _productInOrderRepository;
            }
        }
       
        
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            if (_productRepository != null)
            {
                _productRepository.Dispose();
            }
            if (_orderRepository != null)
            {
                _orderRepository.Dispose();
            }
            if (_productInOrderRepository != null)
            {
                _productInOrderRepository.Dispose();
            }
            if (_userRepository != null)
            {
                _userRepository.Dispose();
            }
            if (_roleRepository != null)
            {
                _roleRepository.Dispose();
            }
            if (_categoryRepository != null)
            {
                _categoryRepository.Dispose();
            }
        }
    }
}
