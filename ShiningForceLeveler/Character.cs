using System;

namespace ShiningForceLeveler
{
    public class Character
    {
        static Random rnd = new Random();
        
        public int upattack = rnd.Next(1, 4);

        public int updefense = rnd.Next(1, 4);

        public int uphp = rnd.Next(1, 5);

        public int upmp = rnd.Next(1, 5);

        public int upagility = rnd.Next(1, 6);

        public static void chaIntro()
        {
            Console.WriteLine($"Input NAME \n Tao\n Max\n Ken\n Mae\n Zylo");

            string selection = Console.ReadLine();
        }

     public void Characters()
        {

        }

        

    }
}
