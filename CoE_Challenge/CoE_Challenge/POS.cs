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

        const decimal TAX = .16m;
        List<IProduct> order = new  List<IProduct>();

        public void AddProduct(IProduct product) => order.Add(product);
        public void Order(List<IProduct> products) => order.AddRange(products);

        public void GetResult(IPrinter printer)
        {
            ApplyPromotions();
            printer.Print(order, GetTotal(), GetTax());
        }

        public decimal GetTotal() => order.Sum(x => x.Price);

        public decimal GetTax() => order.Sum(x => x.Price) * TAX;
    
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
