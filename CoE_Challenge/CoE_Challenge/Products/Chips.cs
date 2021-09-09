namespace CoE_Challenge.Products
{
	public class Chips : IProduct
    {
        public string Name { get; } = "Potato chips";
        public decimal Price { get; set; } = 10;
		public bool IsSnack { get; } = true;
		public bool IsDiscount { get; } = false;
	}
}
