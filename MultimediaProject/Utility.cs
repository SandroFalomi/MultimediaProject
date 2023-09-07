using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimediaProject
{
    internal class Utility
    {
        public static bool Reproduction(MediaPlayer MP)
        {
            string input = "";
            do
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.WriteLine("E' in riproduzione: " + MP.PlayList[MP.index - 1].ToString());
                Console.ResetColor();
                Console.WriteLine((MP.state ? ">" : "||"));
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("(N)\tNext Song\n(P)\tPreview Song\n" + MP.StopResume[(MP.state ? 0 : 1)]);
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Premere E se si vuole uscire");
                input = (input = Console.ReadLine()) != null ? input : "x";
                //ciao

                if (MP.state == true && input.ToUpper() == "R")
                {
                    input = "x";
                }
                if (MP.state == false && input.ToUpper() == "S")
                {
                    input = "x";
                }

            } while (input.ToUpper() is not "N" and not "P" and not "S" and not "E" and not "R");

            switch (input.ToUpper())
            {
                case "N":
                    MP.Next();
                    break;
                case "P":
                    MP.Preview();
                    break;
                case "S":
                    Console.WriteLine("\nStop");
                    MP.Stop();
                    break;
                case "R":
                    MP.Resume();
                    break;
                case "E":
                    return false;
                    //break;
            }
            return true;
        }
    }
}
