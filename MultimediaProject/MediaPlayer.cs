using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimediaProject
{
    internal class MediaPlayer
    {
        
        private List<Multimedia> PlayList = new List<Multimedia>();
        private bool state = true;
        private int index = 1;

        public bool Reproduction()
        {
            string input = "";
            do
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.WriteLine("E' in riproduzione: " + this.PlayList[this.index-1].ToString());
                Console.ResetColor();
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("(N)\tNext Song\n(P)\tPreview Song\n(S)\tStop");
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Premere E se si vuole uscire");
                input = (input = Console.ReadLine()) != null ? input : "x";
            } while (input.ToUpper() is not "N" and not "P" and not "S" and not "E");

            switch (input.ToUpper()) 
            {
                case "N":
                    this.Next();
                break; 
                case "P":
                    this.Preview();
                break; 
                case "S":
                    Console.WriteLine("\nStop");
                    this.Stop();
                break;
                case "E":
                    return false;
                //break;
            }
            return true;
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
