using System;
using System.Collections.Generic;

namespace CoE_Challenge.Products
{
    public static class ProductFactory
    {
        public static IProduct Create<T>() where T : IProduct, new ()
        {
            return new T();
        }

        public static IProduct Create<T>(decimal price) where T : IProduct, new ()
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

        public static List<IProduct> CreateFromList(List<(string className, int quantity)> ListOfClasses) 
		{
            var ListOfTs = new List<IProduct>();
			ListOfClasses.ForEach(x=> ListOfTs.AddRange(AddN(x.className, x.quantity)));
			return ListOfTs;
		}

        static List<IProduct> AddN(string className, int quantity)
		{
            List<IProduct> ListOfTs = new List<IProduct>();
			for(int i = 0; i < quantity; i++) {
                ListOfTs.Add(GetInstance(className) as IProduct);
			}
            return ListOfTs;
		}

        public static List<IProduct> CreateFromList(List<string> ListOfClasses) 
		{
            var ListOfTs = new List<IProduct>();
			ListOfClasses.ForEach(x=> ListOfTs.Add(GetInstance(x) as IProduct));
			return ListOfTs;
		}

        static object GetInstance(string strFullyQualifiedName) 
        {         
             Type t = Type.GetType($"CoE_Challenge.Products.{strFullyQualifiedName}"); 
             return  Activator.CreateInstance(t);         
        }
    }
}
