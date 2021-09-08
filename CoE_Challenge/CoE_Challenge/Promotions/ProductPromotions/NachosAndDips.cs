using CoE_Challenge.Products;
using System.Collections.Generic;
using System.Linq;

namespace CoE_Challenge.Promotions.ProductPromotions
{
    //when you but two bags of nachos or more yo get 1 dip for free
	public class NachosAndDips : IPromotion 
    {
        public bool IsValid(List<IProduct> items)
        {
            return HasNachos(items);
        }

        bool HasNachos(List<IProduct> items) => items.Where(t => t is Nachos).Count() >= 2;

        public void ApplyPromotions(List<IProduct> items) => items.Add(ProductFactory.Create<Dip>(0) as IProduct);
    }
}
