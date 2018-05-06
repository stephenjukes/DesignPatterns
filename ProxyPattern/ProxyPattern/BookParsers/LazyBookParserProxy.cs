using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class LazyBookParserProxy : IBookParser
    {
        private IBook _book;
        public IBookParser _bookParser;

        public LazyBookParserProxy(IBook book)
        {
            _book = book;
        }

        public int GetNumberOfWords()
        {
            if(_bookParser == null)
            {
                _bookParser = new RealBookParser(_book);
            }

            return _bookParser.GetNumberOfWords();
        }
    }
}
