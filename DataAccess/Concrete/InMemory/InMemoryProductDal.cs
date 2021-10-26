﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> { 
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
                new Product{ProductId=2,CategoryId=2,ProductName="Kamera",UnitPrice=15,UnitsInStock=15},
                new Product{ProductId=3,CategoryId=2,ProductName="Televizyon",UnitPrice=15,UnitsInStock=15},
                new Product{ProductId=4,CategoryId=3,ProductName="Bilgisayar",UnitPrice=15,UnitsInStock=15},
                new Product{ProductId=5,CategoryId=4,ProductName="Telefon",UnitPrice=15,UnitsInStock=15},
                new Product{ProductId=6,CategoryId=4,ProductName="Saat",UnitPrice=15,UnitsInStock=15},
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product _productToDelete;
            _productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(_productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductsDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product _productToUpdate;
            _productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _productToUpdate.ProductName = product.ProductName;
            _productToUpdate.CategoryId = product.CategoryId;
            _productToUpdate.UnitPrice = product.UnitPrice;
            _productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
