using System;

namespace MultimediaProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaPlayer player = new MediaPlayer();
            string input = "";
            do
            {
                Console.WriteLine("Inserire cosa si vuole riprodurre: \n (M) Music\n (F) Film");
                input = (input = Console.ReadLine()) != null ? input : "x";
            } while (input.ToUpper() is not "F" and not "M");

            //inizializzo MediaPlayer

            if (input.ToUpper() is "F")
            {
                player.AddList(new Film("Oppenheimer", "Christopher Nolan"));
                player.AddList(new Film("Titanic", "James Cameron"));
                player.AddList(new Film("Pacific Rim", "Guillermo del Toro"));
            }
            else
            {
                player.AddList(new Music("The Search", "NF"));
                player.AddList(new Music("KEN SHIRO", "MACHETE"));
                player.AddList(new Music("No Stylist (feat Drake)", "French Montana"));
            }

            while (player.Reproduction()) { }

        }
    }
}
