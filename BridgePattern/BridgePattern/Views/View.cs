using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    abstract class View
    {
        protected IResource _resource;

        public View(IResource resource)
        {
            _resource = resource;
        }

        public abstract void Show();
    }
}
