using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimediaProject
{
    internal class Music : Multimedia
    {
        internal string Author {  get; }

        public Music(string name, string autore) : base(name) 
        {
            this.Author = autore;
        }

        public override string ToString()
        {
            return base.Name + "\tauthor: " + this.Author;
        }
    }
}
