using CiRent.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.BL.Abstract
{
    public interface IDataHandler
    {
        Task<List<ProductsModel>> BindProducts(int categoryId);
        Task<List<ProductsModel>> BindProducts(int categoryId, int page);
        Task<ProductModel> BindProduct(int productId);
       
    }
}
