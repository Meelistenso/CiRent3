using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CiRent.Entity;

namespace CiRent.DAL.Concrete.EF
{
    public class CiRentContext :DbContext, IDisposable
    {
       public CiRentContext()
            :base("name=CiRentConnectionString") {
            Database.SetInitializer<CiRentContext>(new CreateDatabaseIfNotExists<CiRentContext>());
       }

         
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

        protected override void OnModelCreating(DbModelBuilder modelbuilder) { 
        }
    }
}
