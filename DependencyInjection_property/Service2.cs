using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_property
{
    public class Service2 : IService
    {
        public void Serve()
        {
            Console.WriteLine("Property Service2 class called");
            Console.ReadKey();
        }
    }
}
