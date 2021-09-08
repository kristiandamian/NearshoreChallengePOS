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
			var products = ProductFactory.CreateFromList(new List<string>{ "Chips", "Nachos", "Nachos", "Dip", "Shampoo", "Soap", "Soda"} );
			POS.Instance.AddProductRange(products);
		}
	}
}
