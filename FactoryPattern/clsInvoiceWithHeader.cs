using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class clsInvoiceWithHeader : IInvoice
    {
        public void print()
        {
            Console.WriteLine("Invoice with header.");
            Console.ReadKey();
        }
    }
}
