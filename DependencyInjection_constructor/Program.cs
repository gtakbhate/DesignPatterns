using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1 s1 = new Service1();
            Client c1 = new Client(s1);
            c1.ServeMethod();

            Service2 s2 = new Service2();
            c1 = new Client(s2);
            c1.ServeMethod();

        }
        /*
        -Dependency Injection (DI) is a software design pattern that allows us to develop loosely coupled code.
        
        -Suppose your Client class needs to use two service classes, then the best you can do is to make your 
        Client class aware of abstraction i.e. IService interface rather than implementation 
        i.e. Service1 and Service2 classes. In this way, you can change the implementation of the IService interface 
        at any time (and for how many times you want) without changing the client class code.

         */

    }
}
