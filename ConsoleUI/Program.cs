using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var p in productManager.GetAllByUnitPrice(10, 250))
            {
                Console.WriteLine("{0}:{1}",p.ProductName,p.UnitPrice);
            }*/
            /*CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach(var c in categoryManager.GetAll())
            {
                Console.WriteLine(c.CategoryName);
            }*/
        }
    }
}
