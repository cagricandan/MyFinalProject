﻿using Business.Concrate;
using DataAccess.Concrate.EntityFramework;
using DataAccess.Concrate.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {

        //SOLID
        //fogicay690@seacob.com
        //123456fogicay yada cayfear
        //O = OPEN CLOSED PRİNCİPLE
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();

        }

        //private static void CategoryTest()
        //{
        //    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        //    foreach (var category in categoryManager.GetAll())
        //    {
        //        Console.WriteLine(category.CategoryName);
        //    }
        //}

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));

            var result = productManager.GetAll();

            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    //Console.WriteLine(product.ProductName + " /" + product.CategoryName);
                    Console.WriteLine(product.ProductName + " /" );
                }
            }

            else
            {
                Console.WriteLine(result.Message);
                    
            }
        
            
        }
    }
}
