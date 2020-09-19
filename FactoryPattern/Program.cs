using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int invoicetype = 0;
            IInvoice objInvoice;

            Console.WriteLine("Enter invoice type:");
            invoicetype = Convert.ToInt32(Console.ReadLine());

            objInvoice = clsFactoryInvoice.GetInvoice(invoicetype);
            objInvoice.print();
        }
        /*
         A Factory Pattern or Factory Method Pattern says that just define an interface or abstract class 
        for creating an object but let the subclasses decide which class to instantiate.

        Even if we want to create new invoice type eg: InvoicewithFooter we will not have to modify client program.cs
         
         */
    }
}
