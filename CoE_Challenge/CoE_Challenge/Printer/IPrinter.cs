using CoE_Challenge.Products;
using System.Collections.Generic;

namespace CoE_Challenge.Printer
{
    public interface IPrinter {
        void Print(List<IProduct> order, float total, float tax);
    }
}
