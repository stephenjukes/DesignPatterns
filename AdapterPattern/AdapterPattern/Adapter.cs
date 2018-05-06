using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Adapter : IAdapter
    {
        private ThreePinSocket _threePinSocket;

        public Adapter(ThreePinSocket threePinSocket)
        {
            _threePinSocket = threePinSocket;
        }

        public void PlugIntoTwoPinSocket()
        {
            _threePinSocket.PlugIntoThreePinSocket();
        }
    }
}
