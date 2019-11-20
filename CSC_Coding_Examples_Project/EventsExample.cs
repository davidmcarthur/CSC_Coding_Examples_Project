using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC_Coding_Examples_Project
{

    /// <summary>
    /// Simple program to break down how delegates work in a way that's
    /// easier to understand than a full program using events.
    /// </summary>
    class EventsExample
    {
        public static void Main(string[] args)
        {
            // create an instance of the EventPublisher
            EventPublisher pubisher = new EventPublisher();

            // create an instance of the EventSubscriber
            EventSubscriber subscriber = new EventSubscriber();

            // now we subscribe to the event
            pubisher.evnt += subscriber.HandleEvent;

            // call SomeFunction to test our event
            Console.WriteLine("11");
            pubisher.SomeFunction(11);
            Console.WriteLine("10");
            pubisher.SomeFunction(10);
        }

    }
    /// <summary>
    /// EventPublisher class contains the event delegate 
    /// </summary>
    public class EventPublisher
    {
        public delegate void del(string str);
        
        public event del evnt;

        public void SomeFunction(int x)
        {
            if (x > 10)
                evnt("Event Raised in SomeFunction");
        }
    }
    /// <summary>
    /// Event subscriber class has a single method to handle
    /// the event.
    /// NOTE: It has the same parameters as teh delegate
    /// </summary>
    public class EventSubscriber
    {
        public void HandleEvent(string str)
        {
            Console.WriteLine(str);
        }
    }
}
// Sample Output
// 11
// Event Raised in SomeFunction
// 10