using System.Collections.Generic;

namespace CoE_Challenge.Products
{
    public static class ProductFactory
    {
        public static IProduct Create<T>() where T : IProduct, new ()
        {
            return new T();
        }

        public static IProduct Create<T>(float price) where T : IProduct, new ()
        {
            var newT = new T();
            newT.Price = price;
            return newT;
        }

        public static List<T> CreateMany<T>(int quantity) where T : IProduct, new ()
        {
            var ListOfTs = new List<T>();
            for(int x = 0; x < quantity; x++)
            {
                ListOfTs.Add(new T());
            }
            return ListOfTs;
        }
    }
}
