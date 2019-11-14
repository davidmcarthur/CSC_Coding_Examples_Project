using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC_Coding_Examples_Project
{
    // Interfaces provide a set of common rules, functionality for a class
    // Convenient since multiple inheritance isn't allowed in C#
    // Has a set of definitions or functionality for a class
    // All methods of an interface must be implemented by the class using it

    class InterfacesExample
    {

    }

    // These two classes have no inheritance, and no standardization
    // of how they call start/run, but when we add the Interface 
    // IStartup we get commonality
    public class Car1 : IStartup
    {
        public void Run()
        {

        }

        // Implementing Interface allows us to have required
        // common functions
        public void Start()
        {

        }
        public void Stop()
        {

        }

    }

    public class Car2 : IStartup
    {
        public void Start()
        {

        }

        void IStartup.Start()
        {
            throw new NotImplementedException();
        }

        void IStartup.Stop()
        {
            throw new NotImplementedException();
        }
    }

    interface IStartup
    {
        void Start();
        void Stop();
    }
}
