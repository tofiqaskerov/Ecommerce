using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public class ProductServices
    {
        List<Product> products = new()
        {
            new Product
            {
                Id = 1,
                Name = "1 Super temirli ev.",
                Category = "Ev",
                Kupca = true,
                Area = 125.5M,
                RoomNumber = 5,
                Hit = 200,
                Price = 100000,
                PublishDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."
            },
            new Product
            {
                Id = 2,
                Name = "2 Super temirli ev.",
                Category = "Ev",
                Kupca = true,
                Area = 125.5M,
                RoomNumber = 7,
                Hit = 200,
                Price = 200000,
                PublishDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."
            },
            new Product
            {
                Id = 3,
                Name = "3 Super temirli ev.",
                Category = "Ev",
                Kupca = true,
                Area = 125.5M,
                RoomNumber = 5,
                Hit = 200,
                Price = 300000,
                PublishDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."
            },
            new Product
            {
                Id = 4,
                Name = "4 Super temirli ev.",
                Category = "Ev",
                Kupca = true,
                Area =  125.5M,
                RoomNumber = 5,
                Hit = 200,
                Price = 400000,
                PublishDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."
            },
            new Product
            {
                Id = 5,
                Name = "5 Super temirli ev.",
                Category = "Ev",
                Kupca = true,
                Area = 125.5M,
                RoomNumber = 5,
                Hit = 200,
                Price = 700000,
                PublishDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."
            }
        };
        public List<Product> GetAll()
        {
            return products;
        }
        public Product GetById(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            product.Hit += 1;
            return product;
        }
        public List<Product> GetFilter(int price)
        {
            var product = products.Where(x => x.Price >= price).ToList();
            return product ;
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void RemoveProduct(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            products.Remove(product);
            
        }
        public void UpdatedProduct(int id, string desc)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            product.Description = desc;
        }
    }
}
