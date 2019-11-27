using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC_Coding_Examples_Project
{
    /*
     * Example derived from Udemy 70-483 C# prep course.
     */
    class AsyncAwaitExample
    {
        //public static void Main(string[] args)
        //{
        //    // instance of Asynchronous class calling the async method
        //    AsynchronousClass asc = new AsynchronousClass();
        //    asc.AsyncRanMethod();

        //    for (int i = 0; i < 50; i++)
        //    {
        //        Console.WriteLine("Running Main thread here...");
        //    } 
        //}


    }

    public class AsynchronousClass
    {
        public async Task AsyncRanMethod()
        {
            // this will now run asynchronously with the main thread in the
            // main method.
            await Task.Run(() =>
            {
                BGThreadMethod();
            });
            Console.WriteLine("Asynchronous Method complete...");
        }

        public static async Task BGThreadMethod()
        {
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Background thread number " + i + " ran" );

            }

        }
    }
}

/*
 * SAMPLE OUTPUT
 * 
 * Running Main thread here...
Running Main thread here...
Running Main thread here...
Running Main thread here...
Running Main thread here...
Running Main thread here...
Running Main thread here...
Running Main thread here...
Running Main thread here...
Running Main thread here...
Running Main thread here...
Running Main thread here...
Running Main thread here...
Running Main thread here...
Running Main thread here...
Running Main thread here...
Background thread number 2 ran
Background thread number 3 ran
Background thread number 4 ran
Background thread number 5 ran
Background thread number 6 ran
Background thread number 7 ran
Background thread number 8 ran
Background thread number 9 ran
Asynchronous Method complete...
Running Main thread here...
Running Main thread here...
Running Main thread here...
Running Main thread here...   */
