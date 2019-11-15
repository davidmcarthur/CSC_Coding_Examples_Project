using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC_Coding_Examples_Project
{
    //
    // The following string examples are from Cracking the Coding Interview
    // Author Gayle McDowell
        // Comments are my own
    //
    class IsUniqueString_dict
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(isUniqueString("test"));
            Console.WriteLine(isUniqueString("add"));
            Console.WriteLine(isUniqueString("dave"));
        }

        public static bool isUniqueString(string str)
        {
            // since there are only 128 unique characters if the value of 
            // the string length is 129 or more it can't be unique.
            if (str.Length > 128)
               return false;
            // Now I'm making up my own thing...
            // I thought it would be convenient to use a dictionary to store if
            // if a value was used already with the key being the character.
            // if it is, then we can return false, if not true.
            Dictionary<char, bool> isUsed = new Dictionary<char, bool>();
            for (int i = 0; i < str.Length; i++)
            {

                if (isUsed.ContainsKey(str[i]))
                {
                    return false;
                }
                else
                    isUsed.Add(str[i], true);

            }

            // if we make it through the whole string
            return true;
        }
    }
}
