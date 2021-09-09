namespace CoE_Challenge.Products
{
	public class Dip : IProduct
    {
        public string Name { get; } = "Dip";
        public decimal Price { get; set; } = 10;
		public bool IsSnack { get; } = false;
		public bool IsDiscount { get; } = false;
    }
}
