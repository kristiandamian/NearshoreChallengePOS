namespace CoE_Challenge.Products
{
	public class Shampoo : IProduct
    {
        public string Name { get; } = "Shampoo";
        public float Price { get; set; } = 12.95f;
		public bool IsSnack { get; } = false;
		public bool IsDiscount { get; } = false;
    }
}
