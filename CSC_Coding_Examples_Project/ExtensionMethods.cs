using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC_Coding_Examples_Project
{
    class ExtensionMethods
    {
       /* public static void Main(string[] args)
        {
            string strHello = "Hello";
            string strHelloLwr = "hello";
            // isCap method called on string variable is an extensio method
            // used in the ExtensionMethods class called fromt he StringCapatilized
            // class.
            Console.WriteLine(strHello + " is capatilized? " + strHello.isCap());
            Console.WriteLine(strHelloLwr + " is capatilized? " + strHelloLwr.isCap());
        }
        */
    }

    public static class StringCapatilized
    {

        public static bool isCap(this string s)
        {
            // return false if the string is null or empty or lower
            // return true if first letter is upper
            if (string.IsNullOrEmpty(s)) return false;
            return char.IsUpper(s[0]);
        }
    }

}
// OUTPUT
// Hello is capatilized? True
// hello is capatilized? False