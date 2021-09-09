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
			var products = ProductFactory.CreateFromList(new List<string>{ "Shampoo", "Shampoo","Shampoo","Shampoo",
																			"Soap", "Soap", "Soap", "Soap", "Soap",
																			"Nachos", "Nachos",
																			"Soda",
																			"Chips",  } );
			POS.Instance.AddProductRange(products);
		}
	}
}
