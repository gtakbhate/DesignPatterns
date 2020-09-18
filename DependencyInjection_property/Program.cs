using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_property
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1 service1 = new Service1();
            Client client = new Client();
            client.Service = service1; //Injecting Property
            client.ServeMethod();

            Service2 service2 = new Service2();
            client.Service = service2; //Injecting Property
            client.ServeMethod();


        }
    }
}
