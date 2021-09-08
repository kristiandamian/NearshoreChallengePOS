using CoE_Challenge.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoE_Challenge.Promotions.ProductPromotions
{
	//for each bundle of 1 shampoo and 1 soap get another free soap
	public class ShampooAndSoap : IPromotion 
    {
        public bool IsValid(List<IProduct> items)
        {
            return HasShampos(items) && HasSoap(items);
        }

        bool HasShampos(List<IProduct> items) => items.Where(t => t is Shampoo).Count() > 0;
        bool HasSoap(List<IProduct> items) => items.Where(t => t is Soap).Count() > 0;

        public void ApplyPromotions(List<IProduct> items)
        {
           var shampoos = items.Where(t => t is Shampoo).Count();
           var soaps = items.Where(t => t is Soap).Count();
           var soapsToAdd = Math.Min(shampoos, soaps)/2;
           AddSoaps(items, soapsToAdd);
        }

        public void AddSoaps(List<IProduct> items, int soapsToAdd)
        {
            if(soapsToAdd == 0) soapsToAdd = 1; //when is only one bundle
            for(int x=0; x< soapsToAdd; x++){
                items.Add(ProductFactory.Create<Soap>(0) as IProduct);
            }
        }
    }
}
