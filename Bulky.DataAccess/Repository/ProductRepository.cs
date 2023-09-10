using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product product)
        {
            //_db.Products.Update(product);

            var productFrmDB = _db.Products.FirstOrDefault(q => q.Id == product.Id);

            if (productFrmDB != null)
            {
                productFrmDB.Title = product.Title;
                productFrmDB.ISBN = product.ISBN;
                productFrmDB.Author = product.Author;
                productFrmDB.Description = product.Description;
                productFrmDB.ListPrice = product.ListPrice;
                productFrmDB.Price = product.Price;
                productFrmDB.Price50 = product.Price50;
                productFrmDB.Price100 = product.Price100;
                productFrmDB.CategoryID = product.CategoryID;
                productFrmDB.ProductImages = product.ProductImages;

                //if (product.ImageUrl != null)
                //{
                //    productFrmDB.ImageUrl = product.ImageUrl;
                //}
            }
        }
    }
}
