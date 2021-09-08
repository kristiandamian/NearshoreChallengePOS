using CoE_Challenge.Products;
using System.Collections.Generic;

namespace CoE_Challenge.Promotions
{
	public interface IPromotion
    {
        bool IsValid(List<IProduct> items);
        void ApplyPromotions(List<IProduct> items);
    }
}
