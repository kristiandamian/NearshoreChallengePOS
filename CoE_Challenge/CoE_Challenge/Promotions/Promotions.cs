using CoE_Challenge.Promotions.ProductPromotions;
using System.Collections.Generic;

namespace CoE_Challenge.Promotions
{
	public sealed class Promotions {
        static readonly Promotions instance = new Promotions();

        static Promotions()
        {
        }

        private Promotions()
        {
        }

        public static Promotions Instance
        {
            get
            {
                return instance;
            }
        }

        public List<IPromotion> GetAll() =>
            new List<IPromotion>{ //i know, this is an overkill, but looks so pretty
                PromotionFactory.Create<TwoPlusOne>(),
                PromotionFactory.Create<NachosAndDips>(),
                PromotionFactory.Create<ShampooAndSoap>(),
                PromotionFactory.Create<SodaAndChips>(),
            };
    }
}
