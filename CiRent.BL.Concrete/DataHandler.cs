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
        private readonly IRepositoryHolder scope;
        public DataHandler()
        {
            scope= new RepositoryHolder();
        }

        public async Task<List<ProductsModel>> BindProducts(int categoryId,string sorted)
        {
            ProductsMapper mapper = new ProductsMapper();
            List<Product> res;
            res = await scope.ProductRepository.FetchByAsync(p => p.IdCategory == categoryId);
            switch (sorted)
            {
                case "name":
                    return mapper.EntityToModel(res.OrderBy(p => p.Name).Take(12).ToList(),categoryId);
                case "price":
                    return mapper.EntityToModel(res.OrderBy(p => p.Price).Take(12).ToList(),categoryId);
                default:
                    return mapper.EntityToModel(res.Take(12).ToList(),categoryId);
            }
        }
        public async Task<List<ProductsModel>> BindProducts(string text)
        {
            ProductsMapper mapper = new ProductsMapper();
            var res = await scope.ProductRepository.FetchByAsync(p => p.Name.Contains(text));
            return mapper.EntityToModel(res.Take(12).ToList());
        }
        public async Task<List<ProductsModel>> BindProducts(int categoryId,int page)
        {
            ProductsMapper mapper = new ProductsMapper();
            var res = await scope.ProductRepository.FetchByAsync(p => p.IdCategory == categoryId);
            return mapper.EntityToModel(res.Skip(page * 12).Take(12).ToList(), categoryId);
        }
        public async Task<List<ProductsModel>> BindProducts(int ParentCategoryId)
        {
            ProductsMapper mapper = new ProductsMapper();
            var res = await scope.CategoryRepository.FetchByAsync(p=>p.ParentId == ParentCategoryId);
            return mapper.EntityToModel(res.Take(12).ToList(), ParentCategoryId);
        }
        public async Task<List<ProductsModel>> BindProducts(int categoryId, int page, string orderby)
        {
            ProductsMapper mapper = new ProductsMapper();
            List<Product> res;
            res = await scope.ProductRepository.FetchByAsync(p => p.IdCategory == categoryId);
            switch (orderby) {
                case "name":
                    return mapper.EntityToModel(res.OrderBy(p=>p.Name).Skip(page * 12).Take(12).ToList(), categoryId);
                case "price":
                    return mapper.EntityToModel(res.OrderBy(p=>p.Price).Skip(page * 12).Take(12).ToList(), categoryId);
                default:
                    return mapper.EntityToModel(res.Skip(page * 12).Take(12).ToList(), categoryId);
            }
        }
        public async Task<ProductModel> BindProduct(int productId)
        {
            ProductMapper mapper = new ProductMapper();
            var res = await scope.ProductRepository.GetByIdAsync(productId);
            return mapper.EntityToModel(res);
        }
        public async Task<List<OrderModel>> BindOrder(string id)
        {
            OrderMapper mapper = new OrderMapper();
            var order = await scope.OrderRepository.FetchByAsync(p=>p.IdUser==id);
            return mapper.EntityToModel(order);
        }
        public async Task<List<MainPageCategoryModel>> BindMainCategories()
        {
            MainPageCategoryMapper mapper = new MainPageCategoryMapper();
            var order = await scope.CategoryRepository.FetchAsync();
            return mapper.EntityToModel(order);
        }
        public async Task<List<SidebarCategoriesModel>> BindSideBarCategories(int id)
        {
            SidebarCategoriesMapper mapper = new SidebarCategoriesMapper();
            var order = await scope.CategoryRepository.FetchByAsync(p=>p.Id==id);
            return mapper.EntityToModel(order.FirstOrDefault());
        }

    }
}
