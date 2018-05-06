using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    interface IItem
    {
        string GetHtml(string indentation);
    }
}
