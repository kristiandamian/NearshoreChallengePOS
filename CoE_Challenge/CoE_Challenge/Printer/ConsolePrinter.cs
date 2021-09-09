using CoE_Challenge.Products;
using System;
using System.Collections.Generic;

namespace CoE_Challenge.Printer
{
	public class ConsolePrinter : IPrinter
    {
        public void Print(List<IProduct> order, float total, float tax){
            foreach(var product in order){
                Console.WriteLine($"{product.Name}  --  {product.Price}");
            }
            PrintFooters(total, tax);
        } 

        public void PrintFooters(float total, float tax)
		{
            Console.WriteLine($"SubTotal:           {total}");
            Console.WriteLine($"Tax:             {tax}");
            Console.WriteLine($"Tax:             {total + tax}");
		}
    } 
}
