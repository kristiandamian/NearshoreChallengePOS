using CoE_Challenge.Printer;
using CoE_Challenge.Products;
using System.Collections.Generic;
using System.Linq;

namespace CoE_Challenge
{
	public sealed class POS
    {
        static readonly POS instance = new POS();

        static POS()
        {
        }

        private POS()
        {
        }

        public static POS Instance
        {
            get
            {
                return instance;
            }
        }

        const float TAX = .16f;
        List<IProduct> order = new  List<IProduct>();

        public void AddProduct(IProduct product) => order.Add(product);
        public void AddProductRange(List<IProduct> products) => order.AddRange(products);

        public void GetResult(IPrinter printer)
        {
            ApplyPromotions();
            printer.Print(order, GetTotal(), GetTax());
        }

        public float GetTotal()
        {
            return order.Sum(x => x.Price);
        }

        public float GetTax()
        {
            return order.Sum(x => x.Price) * TAX;
        }
    
        void ApplyPromotions()
        {
            foreach(var promotion in Promotions.Promotions.Instance.GetAll())
            {
                if(promotion.IsValid(order))
                    promotion.ApplyPromotions(order);
            }
        }
    }
}
