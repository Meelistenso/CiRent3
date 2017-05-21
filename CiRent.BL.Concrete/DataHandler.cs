using CiRent.BL.Concrete;
using CiRent.BL.Entities;
using CiRent.DAL.Abstract.IRepositories;
using CiRent.DAL.Concrete.EF.Repositories;
using CiRent.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.BL.Concrete
{
    public class DataHandler
    {
        public readonly IRepositoryHolder scope=new RepositoryHolder();

        public async Task<List<ProductsModel>> BindProducts(int categoryId,string sorted)
        {
            ProductsMapper mapper = new ProductsMapper();
            List<Product> res;
            res = await scope.ProductRepository.FetchByAsync(p => p.IdCategory == categoryId);
            switch (sorted)
            {
                case "name":
                    return mapper.EntityToModel(res.OrderBy(p => p.Name).Take(12).ToList());
                case "price":
                    return mapper.EntityToModel(res.OrderBy(p => p.Price).Take(12).ToList());
                default:
                    return mapper.EntityToModel(res.Take(12).ToList());
            }
        }
        public async Task<List<ProductsModel>> BindProducts(int categoryId,int page)
        {
            ProductsMapper mapper = new ProductsMapper();
            var res = await scope.ProductRepository.FetchByAsync(p => p.IdCategory == categoryId);
            return mapper.EntityToModel(res.Skip(page * 12).Take(12).ToList());
        }
        public async Task<List<ProductsModel>> BindProducts(int categoryId, int page, string orderby)
        {
            ProductsMapper mapper = new ProductsMapper();
            List<Product> res;
            res = await scope.ProductRepository.FetchByAsync(p => p.IdCategory == categoryId);
            switch (orderby) {
                case "name":
                    return mapper.EntityToModel(res.OrderBy(p=>p.Name).Skip(page * 12).Take(12).ToList());
                case "price":
                    return mapper.EntityToModel(res.OrderBy(p=>p.Price).Skip(page * 12).Take(12).ToList());
                default:
                    return mapper.EntityToModel(res.Skip(page * 12).Take(12).ToList());
            }
        }

        public async Task<ProductModel> BindProduct(int productId)
        {
            ProductMapper mapper = new ProductMapper();
            var res = await scope.ProductRepository.GetByIdAsync(productId);
            return mapper.EntityToModel(res);
        }

    }
}
