using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class MediumView : View
    {
        public MediumView(IResource resource) : base(resource) { }

        public override void Show()
        {
            string[] data = { this.GetType().ToString().ToUpper(),
                              _resource.Title(),
                              _resource.Image(),
                              _resource.Snippet(),
                            };
            string html = string.Join("\n\n", data) + "\n\n";
            Console.WriteLine(html);
        }
    }
}
