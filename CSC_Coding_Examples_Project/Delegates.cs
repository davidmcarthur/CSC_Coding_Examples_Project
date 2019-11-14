using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC_Coding_Examples_Project
{
    class Delegates
    {
        // create a delegate with the method signature int (int, int)
        delegate int D(int x, int y);

         static void Main(string[] args)
        {
            // now I have to instanciate my example class and assign a
            // delegate to the desired function
            IntDelExample idm = new IntDelExample();
            D d1 = idm.Add;
            // using my delegate d I can now add 3 and 7 = 10
            Console.WriteLine(d1(3, 7));

            D d2 = idm.Multiply;
            Console.WriteLine(d2(10,10));

            D d3 = idm.Divide;
            Console.WriteLine(d3(24,12));

        }


    }

    public class IntDelExample
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
// OUTPUT

// 10
// 100
// 2