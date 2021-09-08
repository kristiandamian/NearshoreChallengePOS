namespace CoE_Challenge.Products
{
	public class Soap : IProduct
    {
        public string Name { get; } = "Soap";
        public float Price { get; set; } = 8;
		public bool IsSnack { get; } = false;
		public bool IsDiscount { get; } = false;
    }
}
