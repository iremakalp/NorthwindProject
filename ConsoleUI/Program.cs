using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductGetAll();
            //ProductAdd();
            //ProductDelete();
            //GetProductByCategoryId();
            //GetProductsByProductName();
            //ProductGetAll();


            //CategoryAdd();
            //GetCategoryByName();
            //CategoryDelete();
            //CategoryUpdate();
            //CategoryGetAll();

            Console.ReadLine();
        }

        private static void GetProductByCategoryId()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductsByCategory(1))
            {
                Console.WriteLine(product.ProductName);
            }
        }
        private static void GetProductsByProductName()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductsByProductName("Asus"))
            {
                Console.WriteLine(product.ProductName);
            }
        }
        private static void ProductDelete()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            productManager.Delete(new Product
            {
                ProductId = 78
            });
        }

        private static void ProductGetAll()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void ProductAdd()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            productManager.Add(new Product
            {
                ProductName = "Asus",
                CategoryId = 11,
                QuantityPerUnit = "100 ",
                UnitPrice = 15,
                UnitsInStock = 10
            });
            Console.WriteLine("Ürün eklendi");
        }

        private static void CategoryGetAll()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void CategoryUpdate()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            categoryManager.Update(new Category
            {
                CategoryId = 11,
                CategoryName = "Laptop"
            });
            Console.WriteLine("kategori güncellendi");
        }

        private static void CategoryDelete()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            categoryManager.Delete(new Category
            {
                CategoryId = 12
            });
            Console.WriteLine("kategori silindi");
        }
        private static void GetCategoryByName()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetCategoryByName("Deneme"))
            {
                Console.WriteLine(category.CategoryId + " " + category.CategoryName);
            }
        }
        private static void CategoryAdd()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            categoryManager.Add(new Category
            {
                CategoryName = "Deneme"
            });
            Console.WriteLine("Kategori eklendi");
        }
    }
}
