using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class RealBookParser : IBookParser
    {
        private IBook _book;

        public RealBookParser(IBook book)
        {
            _book = book;
        }

        public int GetNumberOfWords()
        {
            int words = _book.Content.Length;

            Console.WriteLine($"{_book.Title} has {words} words.");
            return words;
        }
    }
}
