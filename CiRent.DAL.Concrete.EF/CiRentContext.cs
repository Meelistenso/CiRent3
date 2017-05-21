using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CiRent.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using CiRent.DAL.Concrete.EF;
using CiRent.DAL.Abstract;
using System.Data.Entity.Infrastructure;

namespace CiRent.DAL.Concrete.EF
{
    public class CiRentContext : IdentityDbContext<User>, ICiRentContext
    {
       public CiRentContext()
            :base("name=CiRentConnectionString") {
            Database.SetInitializer<CiRentContext>(new CreateDatabaseIfNotExists<CiRentContext>());
       }

         
       public IDbSet<Product> Product { get; set; }
       public IDbSet<Order> Order { get; set; }
       public IDbSet<Category> ParamDictionary { get; set; }
       public IDbSet<ProductsInOrder> ProductInOrder { get; set; }
       //public IDbSet<ProductType> ProductType { get; set; }
       public IDbSet<EnumType> EnumType { get; set; }
       public IDbSet<EnumValue> EnumValue { get; set; }

        public IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
        public static CiRentContext Create()
        {
            return new CiRentContext();
        }
        public DbEntityEntry Entry(object entity)
        {
            return base.Entry(entity);
        }

        void IDisposable.Dispose()
        {
            base.Dispose();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
