using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();


            UserManager userManager = new UserManager(new EfUserDal());
            var result1 = userManager.Get(2).Data;

            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }

            //var result = userManager.GetClaims(result1)
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            //ProductManager productManager = new ProductManager(new EfProductDal());

            //var result = productManager.GetProductDetails();
            //if(result.Success==true)
            //{
            //    foreach (var product in result.Data)
            //    {
            //        Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}
        }
    }
}
