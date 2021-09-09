using CoE_Challenge.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoE_Challenge.Promotions.ProductPromotions
{
	//for each bundle of 1 2-lts soda and 1 bag of chips, you get another bag of chips for free
    public class SodaAndChips : IPromotion 
    {
        public bool IsValid(List<IProduct> items)
        {
            return HasSodas(items) && HasChips(items);
        }

        bool HasSodas(List<IProduct> items) => items.Where(t => t is Soda).Count() > 0;
        bool HasChips(List<IProduct> items) => items.Where(t => t is Chips).Count() > 0;

        public void ApplyPromotions(List<IProduct> items)
        {
           var sodas = items.Where(t => t is Soda).Count();
           var chips = items.Where(t => t is Chips).Count();
           var chipsToAdd = Math.Min(sodas, chips);
           AddChips(items, chipsToAdd);
        }

        public void AddChips(List<IProduct> items, int chipsToAdd)
        {
            for(int x=0; x< chipsToAdd; x++){
                items.Add(ProductFactory.Create<Chips>(0) as IProduct);
            }
        }
    }
}
