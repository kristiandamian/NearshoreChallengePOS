
namespace CoE_Challenge.Products
{
	public interface IProduct
    {
        string Name { get; }
        decimal Price { get; set; }
        bool IsSnack { get; }
        bool IsDiscount { get; }
    }
}
