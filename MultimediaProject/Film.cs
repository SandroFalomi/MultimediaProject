using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimediaProject
{
    internal class Film : Multimedia
    {
        internal string Director { get; }

        public Film(string name, string director) : base(name)
        {
            this.Director = director;
        }

        public override string ToString()
        {
            return base.Name + "\tdirector: " + this.Director;
        }
    }
}
