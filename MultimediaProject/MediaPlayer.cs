using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimediaProject
{
    internal class MediaPlayer
    {

        public List<Multimedia> PlayList = new List<Multimedia>();
        public bool state = true;
        public int index = 1;
        public string[] StopResume = new string[2] { "(S)\tStop", "(R)\tResume" };

        public bool Reproduction()
        {
            return Utility.Reproduction(this);
        }

        public void AddList (Multimedia file) 
        { 
            PlayList.Add(file); 
        }   

        public void Stop ()
        {
            this.state = false;

        }

        public void Next()
        {
            this.Resume();
            this.index = (index + 1 > this.PlayList.Count() ? 1: index = index + 1);
        }

        public void Preview()
        {
            this.index = (index - 1 < 1 ? this.PlayList.Count() : index = index - 1);
            this.Resume();
        }

        public void Resume()
        {
            this.state = true;
        }
    }
}
