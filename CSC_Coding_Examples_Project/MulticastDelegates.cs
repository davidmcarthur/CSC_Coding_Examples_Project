using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC_Coding_Examples_Project
{
    
    class MulticastDelegates
    {
        // this delegate declaration is the magic maker
        // need this to create a delegate variable to use in the program main.
        delegate void D(int a, int b);
        /* static void Main(string[] args)
         {
            // create an instance of the Examples class
             Examples e = new Examples();
             // create a delegate variable d
             D d;
             // the first use of d is on the example instance e to print the add
             d = e.PrintAdd;
             Console.WriteLine("Invoke delegate with one target: ");
             // add 6+7
             d(6, 7);
             // If you don't unsubscribe from Add it will call every time 
             // any delegate is called. this is true for all proceeding 
             // delegate subscriptions.
             Console.WriteLine("Unsubscribe from Add");
             d -= e.PrintAdd;
             Console.WriteLine("Invoke using += to create two additional targets");
             d += e.PrintMultiply;
             d(5, 5);
             d += e.PrintSubtract;
             d(10, 3);
         }
         */
    }

    public class Examples
    {
        public void PrintAdd(int a, int b)
        {
            Console.WriteLine("Add: a + b = " + (a+b));
        }

        public void PrintMultiply(int a, int b)
        {
            Console.WriteLine("Multiply: a * b = " + (a * b));
        }
        public void PrintSubtract(int a, int b)
        {
            Console.WriteLine("Subtract: a - b = " + (a - b));
        }

    }
}
//  OUTPUT
// Invoke delegate with one target:
// Add: a + b = 13
// Unsubscribe from Add
// Invoke using += to create two additional targets
// Multiply: a* b = 25
// Multiply: a* b = 30
// Subtract: a - b = 7