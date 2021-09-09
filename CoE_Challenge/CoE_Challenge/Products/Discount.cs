namespace CoE_Challenge.Products
{
	public class Discount : IProduct
    {
        public string Name { get; } = "Discount";
        public decimal Price { get; set; }
		public bool IsSnack { get; } = false;
		public bool IsDiscount { get; } = true;
    }
}
