using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class clsInvoiceWithoutHeader : IInvoice
    {
        public void print()
        {
            Console.WriteLine("Invoice without header.");
            Console.ReadKey();
        }
    }
}
