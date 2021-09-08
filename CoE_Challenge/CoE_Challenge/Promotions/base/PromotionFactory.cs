namespace CoE_Challenge.Promotions
{
    public static class PromotionFactory
    {
        public static IPromotion Create<T>() where T : IPromotion, new ()
        {
            return new T();
        }
    }
}
