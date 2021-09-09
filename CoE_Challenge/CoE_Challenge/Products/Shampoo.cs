namespace CoE_Challenge.Products
{
	public class Shampoo : IProduct
    {
        public string Name { get; } = "Shampoo";
        public decimal Price { get; set; } = 12.95m;
		public bool IsSnack { get; } = false;
		public bool IsDiscount { get; } = false;
    }
}
