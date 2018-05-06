using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Item : IItem
    {
        private string _text;

        public Item(string text)
        {
            _text = text;
        }

        public string GetHtml(string indentation)
        {
            return _text;
        }
    }
}
