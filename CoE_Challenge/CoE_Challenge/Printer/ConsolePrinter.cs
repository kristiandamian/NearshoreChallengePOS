using CoE_Challenge.Models;
using CoE_Challenge.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoE_Challenge.Printer
{
	public class ConsolePrinter : IPrinter
    {
        public void Print(List<IProduct> order, decimal total, decimal tax){
            PrintHeader();
            foreach(var product in GroupProducts(order)){
                Console.WriteLine($"  {product.Quantity} - {product.Name} --> Total:  {product.Total}");
            }
            PrintFooters(total, tax);
        } 

        List<ProductGrouped> GroupProducts(List<IProduct> order)
		{
            return order.GroupBy(x => x.Name) .Select(grp => new ProductGrouped {
                                                        Name     = grp.Key,
                                                        Total    = grp.Sum(x => x.Price),
                                                        Quantity = grp.Count()
				                                    }).ToList();
		}

        void PrintFooters(decimal total, decimal tax)
		{
            PrintLine();
            Console.WriteLine($"  SubTotal:          $ {total}");
            Console.WriteLine($"  Tax:               $ {tax}");
            Console.WriteLine($"  Total:             $ {total + tax}");
            PrintLine();
		}

        void PrintHeader()
		{
            PrintLine();
            PrintLine();
		}

        void PrintLine() => Console.WriteLine("-------------------------------------");
    } 
}
