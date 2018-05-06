﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class TheManAndTheFly : IBook
    {
        public string Title { get; } = "The Man and the Fly";

        public string Content { get; } = "There was once a Bald Man who sat down after work on a hot summer's day. A Fly came up and kept buzzing about his bald pate, and stinging him from time to time. The Man aimed a blow at his little enemy, but his palm came on his head instead. Again the Fly tormented him, but this time the Man was wiser and said: \"You will only injure yourself if you take notice of despicable enemies.\"";
    }
}