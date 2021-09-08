using CoE_Challenge.Products;
using CoE_Challenge.Printer;

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
			POS.Instance.AddProducto(ProductFactory.Create<Chips>());
			POS.Instance.AddProducto(ProductFactory.Create<Nachos>());
			POS.Instance.AddProducto(ProductFactory.Create<Dip>());
			POS.Instance.AddProducto(ProductFactory.Create<Nachos>());
			POS.Instance.AddProducto(ProductFactory.Create<Shampoo>());
			POS.Instance.AddProducto(ProductFactory.Create<Soap>());
			POS.Instance.AddProducto(ProductFactory.Create<Soda>());
		}
	}
}
