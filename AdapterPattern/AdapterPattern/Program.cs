using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The Adapter Pattern allows two incompatible interfaces (not the c# keyword) compatible, rather like an every day adapter would work

// This pattern seems trivial to me. It DOESN'T JOIN two interfaces like an every day adapter would, but REPLICATES the behaviour of one interface to be compatible with the other. (notice that the twoPinPlug variable never interacts with the adapter in the same way that the adapter interacts with the threePinSocket)

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var twoPinPlug = new TwoPinPlug();
            var threePinSocket = new ThreePinSocket();
            var adapter = new Adapter(threePinSocket);

            adapter.PlugIntoTwoPinSocket();

        }
    }
}
