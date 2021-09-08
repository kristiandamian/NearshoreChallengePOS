namespace CoE_Challenge.Products
{
	public class Discount : IProduct
    {
        public string Name { get; } = "Discount";
        public float Price { get; set; }
		public bool IsSnack { get; } = false;
		public bool IsDiscount { get; } = true;
    }
}
