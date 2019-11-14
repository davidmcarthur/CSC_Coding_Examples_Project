using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC_Coding_Examples_Project
{
    
    class MulticastDelegates
    {
        delegate void D(int a, int b);
        static void Main(string[] args)
        {
            
            Examples e = new Examples();
            D d;
            d = e.PrintAdd;
            Console.WriteLine("Invoke delegate with one target: ");
            d(6, 7);
            Console.WriteLine("Unsubscribe from Add");
            d -= e.PrintAdd;
            Console.WriteLine("Invoke using += to create two additional targets");
            d += e.PrintMultiply;
            d(5, 5);
            d += e.PrintSubtract;
            d(10, 3);
        }

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