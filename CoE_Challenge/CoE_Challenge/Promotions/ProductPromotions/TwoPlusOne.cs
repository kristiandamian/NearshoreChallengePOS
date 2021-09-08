using CoE_Challenge.Models;
using CoE_Challenge.Products;
using System.Collections.Generic;
using System.Linq;

namespace CoE_Challenge.Promotions.ProductPromotions
{
	//Add a promotional 2x1 discount for every product but any snack
	public class TwoPlusOne : IPromotion 
    {
        public bool IsValid(List<IProduct> items)
        {
           return HasTwoProductExceptSnack(items);
        }

        bool HasTwoProductExceptSnack(List<IProduct> items) => items.Where(t => !t.IsSnack && !t.IsDiscount).GroupBy(x => x.Name).Where(grp => grp.Count() >= 2).Count() > 0;

        public void ApplyPromotions(List<IProduct> items)
        {
            foreach(var product in GetDistinctProducts(items))
            {
                UpdatePrice(items, product.Name, product.NumberOfItems);
            }
        }

        public void UpdatePrice(List<IProduct> items, string name, int numberOfItems)
        {
            foreach(var product in items.Where(x => x.Name == name).Take(numberOfItems/2))
            {
                product.Price = 0;
            }
        }

        public List<ProductTwoPlusOne> GetDistinctProducts(List<IProduct> items)
        {
            return DistinctProducts(items).Select(grp => new ProductTwoPlusOne {
                                                    Name = grp.Key,
                                                    NumberOfItems = grp.Count()
                                                }).ToList();
        }

        IEnumerable<IGrouping<string, IProduct>> DistinctProducts(List<IProduct> items)
        {
            return items.Where(t => !t.IsSnack && !t.IsDiscount)
                        .GroupBy(x => x.Name)
                        .Where(grp => grp.Count() >= 2);
        }
    }
}
