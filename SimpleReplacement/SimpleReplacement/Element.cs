using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleReplacement
{
    class Element
    {
        

        public char symbol;
        public char code;

        public Element(char sym, char rep)
        {
            this.symbol = sym;
            this.code = rep;
        }
    }
}
