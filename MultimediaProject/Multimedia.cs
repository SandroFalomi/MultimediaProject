using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimediaProject
{
    internal abstract class Multimedia
    {
        internal string Name { get; }

        public Multimedia(string name)
        {
            this.Name = name;
        }
    }
}
