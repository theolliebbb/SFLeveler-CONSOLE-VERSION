using System;

namespace ShiningForceLeveler
{
    class Program: Character
    {
        static void Main(string[] args)
        {
            
            string selection;
            Character character = new Character();
            Tao tao = new Tao();
            tao.maxunpro = true;
            if (tao.maxunpro == true)
            {
                tao.maxcharacterClass = tao.maxcharaun;
            }
            else
            {
                tao.maxcharacterClass = tao.maxcharapro;
            }

           
            tao.unpro = true;
            if (tao.unpro == true)
            {
                tao.characterClass = tao.charaun;
            }
            else
            {
                tao.characterClass = tao.charapro;

                

            }

           
            
            tao.intro();
            



            


            



            }
            
    }
}
