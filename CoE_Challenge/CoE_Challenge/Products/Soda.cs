namespace CoE_Challenge.Products
{
	public class Soda : IProduct
    {
        public string Name { get; } = "Soda (2 lts)";
        public decimal Price { get; set; } = 13.5m;
		public bool IsSnack { get; } = false;
		public bool IsDiscount { get; } = false;
    }
}
