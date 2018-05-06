using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  The Proxy Pattern can be implemented when the client (code) wants to use code that is:
    - in a different address space (remote proxy)
    - expensive to instantiate (virtual proxy), or 
    - potentially risky. (protection proxy)
  The pattern used in this project is a virtual proxy.
*/

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new TheManAndTheFly();
            var proxy = new LazyBookParserProxy(book);

            Console.WriteLine(CheckFor(proxy._bookParser));
            proxy.GetNumberOfWords();
            Console.WriteLine(CheckFor(proxy._bookParser));
        }

        static string CheckFor(IBookParser parser)
        {
            if(parser == null)
            {
                return "null";
            }
            else
            {
                return parser.GetType().ToString();
            }
        }
    }
}
