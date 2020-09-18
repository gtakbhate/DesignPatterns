using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_constructor
{
    public class Service1 : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service1 class called");
            Console.ReadLine();
        }
    }
}
