using CoE_Challenge.Products;
using CoE_Challenge.Printer;
using System.Collections.Generic;

namespace CoE_Challenge
{
	class Program
	{
		static void Main(string[] args)
		{
			AddProducts();
			POS.Instance.GetResult(new ConsolePrinter());
		}

		static void AddProducts()
		{
			var lines = ProductFactory.CreateFromList(new List<(string className, int quantity)>{("Shampoo", 4), ("Soap", 5), ("Nachos", 2), 
																									("Soda", 1), ("Chips", 1) });
			POS.Instance.Order(lines);
		}
	}
}
