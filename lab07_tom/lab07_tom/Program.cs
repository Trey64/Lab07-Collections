using System;
using System.Collections.Generic;

namespace lab07_tom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Product product = new Product();
            




            Inventory<Product> productInventory = new Inventory<Product> ();

            productInventory.Add(new Product() { TvBrand = Brand.Samsung });
            productInventory.Add(new Product() { TvBrand = Brand.Sony });
            productInventory.Add(new Product() { TvBrand = Brand.LG });
            productInventory.Add(new Product() { TvBrand = Brand.Vizio });

            //Inventory<Product> productInventory2 = new Inventory<Product> {  };



            foreach (Product p in productInventory)
            {
                Console.WriteLine(p.TvBrand);
            }


            //productInventory.Remove();


            foreach (Product p in productInventory)
            {
                Console.WriteLine(p.TvBrand);
            }


            Console.Read();
        }
    }
}
