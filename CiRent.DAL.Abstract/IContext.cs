using CiRent.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.DAL.Abstract
{
    public interface IContext:IDisposable
    {
        IDbSet<Product> Product { get; set; }
        IDbSet<Order> Order { get; set; }
        IDbSet<ParamDictionary> ParamDictionary { get; set; }
        IDbSet<ProductInOrder> ProductInOrder { get; set; }
        IDbSet<ProductType> ProductType { get; set; }
        IDbSet<ProductTypeDictionary> ProductTypeDictionary { get; set; }
        IDbSet<ProductValue> ProductValue { get; set; }
        IDbSet<Role> Role { get; set; }
        IDbSet<User> User { get; set; }
        IDbSet<UserInRole> UserInRole { get; set; }
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbEntityEntry Entry(object entity);
        int SaveChanges();

        Task<int> SaveChangesAsync();
        Database Database { get; }
    }
}
