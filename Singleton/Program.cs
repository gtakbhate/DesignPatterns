using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Note: debug program to check instance assignment*/

            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;

        }

        /*
         Explanation of the code:

- This implementation is thread-safe.
- In the following code, the thread is locked on a shared object and checks whether an instance has been created or not.
- This takes care of the memory barrier issue and ensures that only one thread will create an instance.
- For example: Since only one thread can be in that part of the code at a time, by the time the second thread enters it,
        the first thread will have created the instance, so the expression will evaluate to false.
- The biggest problem with this is performance; performance suffers since a lock is required every time an instance is requested.
         
         */
    }
}
