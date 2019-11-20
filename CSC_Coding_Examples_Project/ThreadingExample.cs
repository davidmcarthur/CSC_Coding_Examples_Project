using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSC_Coding_Examples_Project
{
    class ThreadingExample
    {
        public static void Main(string[] args)
        {
            // create two instances of Thread which each call a different function
            Thread threadx = new Thread(WriteX);
            Thread thready = new Thread(WriteY);

            threadx.Start();
            thready.Start();
        }

        // Threading method for writing Y
        private static void WriteY()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("Y");
            }
        }
        // Threading method for writing X
        private static void WriteX()
        {
            for (int i = 0; i <1000; i++)
            {
                Console.Write("X");
            }
            
        }
    }


}
