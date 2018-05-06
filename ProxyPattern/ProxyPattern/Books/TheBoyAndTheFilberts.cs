using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class TheBoyAndTheFilberts : IBook
    {
        public string Title { get; } = "The Boy and the Filberts";
        
        public string Content { get; } = "A Boy was given permission to put his hand into a pitcher to get some filberts. But he took such a great fistful that he could not draw his hand out again. There he stood, unwilling to give up a single filbert and yet unable to get them all out at once. Vexed and disappointed he began to cry. \"My boy,\" said his mother, \"be satisfied with half the nuts you have taken and you will easily get your hand out. Then perhaps you may have some more filberts some other time.\" Do not attempt too much at once.";
    }
}
