using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
  public  class clsFactoryInvoice
    {
        public static IInvoice GetInvoice(int InvoiceType)
        {
            IInvoice objinvoice;
            if (InvoiceType == 1)
                objinvoice = new clsInvoiceWithHeader();
            else if (InvoiceType == 2)
                objinvoice = new clsInvoiceWithoutHeader();
            else
                return null;

            return objinvoice;
        }

    }
}
