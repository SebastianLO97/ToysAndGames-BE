using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IGenericRepository<Product> _productRepository;

        public ProductService(IGenericRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productRepository.GetAll();
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetById(id);
        }

        public Product CreateProduct(Product product)
        {
            var productCreated = _productRepository.Create(product);
            _productRepository.Save();

            return productCreated;
        }

        public Product UpdateProduct(Product product)
        {
            var productDb = _productRepository.GetById(product.Id);
            productDb.AgeRestriction = product.AgeRestriction;
            productDb.Name = product.Name;
            productDb.Price = product.Price;
            productDb.Description = product.Description;
            productDb.CompanyId = product.CompanyId;
 
            var productUpdated = _productRepository.Update(productDb);

            return productUpdated;
        }

        public void DeleteProduct(int id)
        {
            _productRepository.Delete(id);
            _productRepository.Save();
        }
    }
}
