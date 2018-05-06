using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class ItemList : IItem
    {
        private string _title;
        private List<IItem> _subItems;
        
        public ItemList(string title, List<IItem> subItems)
        {
            _title = title;
            _subItems = subItems;
        }

        public string GetHtml(string indentation)
        {
            string html = $"\n{indentation}<h1>{_title}</h1>\n";
            html += $"{indentation}<ul>\n";

            foreach(var item in _subItems)
            {
                html += $"{indentation}    <li>";
                html += item.GetHtml(indentation + "        "); // this recursion is the key to the pattern
                html += "</li>\n";
            }

            html += $"{indentation}</ul>\n    ";

            return html;
        }
    }
}
