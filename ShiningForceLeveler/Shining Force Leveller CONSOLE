using System;
namespace ShiningForceLeveler
{
    public class Tao : Character
    {
        static Random rnd = new Random();
        //tao//
        public string charaun = "Mage";
        public string charapro = "Wizard";
        public string chara = "Tao";
        public bool canusemp = true;
        public int level = 1;
        public int attack = 4;
        public int defense = 4;
        public int hp = 15;
        public int mp = 12;
        public int agility = 14;
        
        public int blvl = 1;
        public void Taowiz()
        {

        }
        public bool unpro = true;

        public string characterClass = "Mage";

        
         
        //max//
        public string maxcharaun = "Swordsman";
        public string maxcharapro = "Hero";
        public string maxchara = "Max";
        public bool maxcanusemp = false;
        public int maxlevel = 1;
        public int maxattack = 7;
        public int maxdefense = 6;
        public int maxhp = 14;
        public int maxmp = 8;
        public int maxagility = 12;
        public int maxboltlvl = 0;
        public string maxyn2;
        public bool maxunpro = true;
        public string maxcharacterClass = "Swordsman";

        //zylo//
        public string zylocharaun = "Wolfman";
        public string zylocharapro = "Wolf Baron";
        public string zylochara = "Zylo";
        public bool zylocanusemp = false;
        public int zylolevel = 1;
        public int zyloattack = 9;
        public int zylodefense = 5;
        public int zylohp = 17;
        public int zylomp = 0;
        public int zyloagility = 14;
        
        public string zyloyn2;
        public bool zylounpro = true;
        public string zylocharacterClass = "Wolfman";





        public void promote()
        {
            if (unpro == true && level >= 10)

            {
                Console.WriteLine("Your character is ready to be promoted! Promote? y/n");
                string promoyn = Console.ReadLine();
                if (promoyn == "y")
                {
                    Console.WriteLine($"Congratulations! {charaun} {chara}  has been promoted to the rank of {charapro}!");
                    level = 1;
                    characterClass = charapro;
                    unpro = false;
                    if (chara == "Max")
                    {
                        canusemp = true;
                    }
                }
            }

        }


        public void taolevelUp()
        {
            int upattack = rnd.Next(1, 4);

        int updefense = rnd.Next(1, 4);

        int uphp = rnd.Next(1, 5);

        int upmp = rnd.Next(1, 5);

        int upagility = rnd.Next(1, 6);
        level += 1;
            Console.WriteLine($"{characterClass} {chara} has Leveled up from Level {level - 1} to {level}");
            attack += upattack;
            Console.WriteLine($"Attack increased from {attack - upattack} to {attack}");
            defense += updefense;
            Console.WriteLine($"Defense increased from {defense - updefense} to {defense}");
            hp += uphp;
            Console.WriteLine($"HP increased from {hp - uphp} to {hp}");
            agility += upagility;
            Console.WriteLine($"Agility increased from {agility - upagility} to {agility}");
            if (canusemp == false)
            {
                mp += 0;

            }
            else
            {
                mp += upmp;
                Console.WriteLine($"MP increased from {mp - upmp} to {mp}");

            }
            if (level == 5 && characterClass == "Mage")
            {
                Console.WriteLine("Tao learned Blaze 2!");
                blvl = 2;
            }
            if (level == 9 && characterClass == "Mage")
            {
                Console.WriteLine("Tao learned Blaze 3!");
                blvl = 3;
            }
            if ((level == 15 && characterClass == "Mage") || (level == 5 && characterClass == "Wizard" && blvl > 4))
            {
                Console.WriteLine("Tao learned Blaze 4!");
                blvl = 4;
            }


            promote();
            Console.WriteLine("Level up again? y/n, 'Enter'");

            string yn2 = Console.ReadLine();

            if (yn2 == "n")
            {
                Console.Write("Press 'Enter' to return to the Character Selection Screen");
                Console.ReadLine();
                intro();

            }
            else if (yn2 == "y")
            {
                taolevelUp();
            }
            else
            {
                Console.Write("Press 'Enter' to return to the Character Selection Screen");
                Console.ReadLine();
                intro();
            }




        }
        public void intro()
        {
            Console.WriteLine($"Input NAME \n Tao\n Max\n Zylo");

            string selection = Console.ReadLine();
            while (selection != "Max" && selection != "Tao" && selection != "Zylo")
            {
                Console.WriteLine("Choose a character!");
                selection = Console.ReadLine();
            }
            if (selection == "Max")
            {
                selection = "n";
                mLevelUp();
                intro();
            }
            else if (selection == "Tao")
            {
                selection = "n";
                tLevelUp();
                intro();
            }
            else if (selection == "Zylo")
            {
                selection = "n";
                zLevelUp();
                intro();
            }
        }
            public void tLevelUp()
        {
            chara = "Tao";

            Console.WriteLine($"\n{chara}");
            Console.WriteLine($"{characterClass}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Attack: {attack}");
            Console.WriteLine($"Defense: {defense}");
            Console.WriteLine($"Agility: {agility}");
            Console.WriteLine($"HP: {hp}");
            Console.WriteLine($"MP: {mp}");
            Console.WriteLine( $"Spells: Blaze {blvl}" );
            


            

        Console.WriteLine("Level Up? (y/n)");

            string yn = Console.ReadLine();
            while (yn == "y")
            {
                taolevelUp();
            }
            Console.Write("Press 'Enter' to return to the Character Selection Screen");
            Console.ReadLine();
            intro();



        }

        //other
        public void mLevelUp()
        {
            chara = "Max";
            
            Console.WriteLine($"\n{maxchara}");
            Console.WriteLine($"{maxcharacterClass}");
            Console.WriteLine($"Level: {maxlevel}");
            Console.WriteLine($"Attack: {maxattack}");
            Console.WriteLine($"Defense: {maxdefense}");
            Console.WriteLine($"Agility: {maxagility}");
            Console.WriteLine($"HP: {maxhp}");
            Console.WriteLine($"MP: {maxmp}");
                if (maxboltlvl > 0)
                    {
                Console.WriteLine($"Spells: Egress, Bolt {maxboltlvl}");
                    
                    }
            Console.WriteLine("Level Up? (y/n)");

            string yn = Console.ReadLine();
            while (yn == "y")
            {
                maxlevelUp();
            }
            Console.Write("Press 'Enter' to return to the Character Selection Screen");
            Console.ReadLine();
            intro();


        }
        public void zLevelUp()
        {
            chara = "Zylo";

            Console.WriteLine($"\n{zylochara}");
            Console.WriteLine($"{zylocharacterClass}");
            Console.WriteLine($"Level: {zylolevel}");
            Console.WriteLine($"Attack: {zyloattack}");
            Console.WriteLine($"Defense: {zylodefense}");
            Console.WriteLine($"Agility: {zyloagility}");
            Console.WriteLine($"HP: {zylohp}");
            Console.WriteLine($"MP: {zylomp}");
            
            Console.WriteLine("Level Up? (y/n)");

            string yn = Console.ReadLine();
            while (yn == "y")
            {
                zylolevelUp();
            }
            Console.Write("Press 'Enter' to return to the Character Selection Screen");
            Console.ReadLine();
            intro();


        }
        public void maxlevelUp()
        {
            int upattack = rnd.Next(1, 4);

            int updefense = rnd.Next(1, 4);

            int uphp = rnd.Next(1, 5);

            int upmp = rnd.Next(1, 5);

            int upagility = rnd.Next(1, 6);
            maxlevel += 1;
            Console.WriteLine($"{maxcharacterClass} {maxchara} has Leveled up from Level {maxlevel - 1} to {maxlevel}");
            maxattack += upattack;
            Console.WriteLine($"Attack increased from {maxattack - upattack} to {maxattack}");
            maxdefense += updefense;
            Console.WriteLine($"Defense increased from {maxdefense - updefense} to {maxdefense}");
            maxhp += uphp;
            Console.WriteLine($"HP increased from {maxhp - uphp} to {maxhp}");
            maxagility += upagility;
            Console.WriteLine($"Agility increased from {maxagility - upagility} to {maxagility}");
            if (maxcanusemp == false)
            {
                mp += 0;

            }
            else
            {
                maxmp += upmp;
                Console.WriteLine($"MP increased from {maxmp - upmp} to {maxmp}");

            }
            if (maxlevel == 5 && maxcharacterClass == "Hero")
            {
                Console.WriteLine("Max learned Bolt 1!");
                maxboltlvl = 1;
            }
            if (maxlevel == 9 && maxcharacterClass == "Hero")
            {
                Console.WriteLine("Max learned Bolt 2!");
                maxboltlvl = 2;
            }
            if (maxlevel == 15 && maxcharacterClass == "Hero")
            {
                Console.WriteLine("Max learned Bolt 3");
                maxboltlvl = 3;
            }
            maxpromote();
            Console.WriteLine("Level up again? y/n, 'Enter'");

            string yn2 = Console.ReadLine();

            if (yn2 == "n")
            {
                Console.Write("Press 'Enter' to return to the Character Selection Screen");
                Console.ReadLine();
                intro();

            }
            else if (yn2 == "y")
            {
                maxlevelUp();
            }
            else
            {
                Console.Write("Press 'Enter' to return to the Character Selection Screen");
                Console.ReadLine();
                intro();
            }
        }

            public void zylolevelUp()
            {
            int upattack = rnd.Next(1, 4);

            int updefense = rnd.Next(1, 4);

            int uphp = rnd.Next(1, 5);

            int upmp = rnd.Next(1, 5);

            int upagility = rnd.Next(1, 6);
            zylolevel += 1;
                Console.WriteLine($"{zylocharacterClass} {zylochara} has Leveled up from Level {zylolevel - 1} to {zylolevel}");
                zyloattack += upattack;
                Console.WriteLine($"Attack increased from {zyloattack - upattack} to {zyloattack}");
                zylodefense += updefense;
                Console.WriteLine($"Defense increased from {zylodefense - updefense} to {zylodefense}");
                zylohp += uphp;
                Console.WriteLine($"HP increased from {zylohp - uphp} to {maxhp}");
                zyloagility += upagility;
                Console.WriteLine($"Agility increased from {zyloagility - upagility} to {zyloagility}");
               
                zylopromote();
            Console.WriteLine("Level up again? y/n, 'Enter'");

            string yn2 = Console.ReadLine();

            if (yn2 == "n")
            {
                Console.Write("Press 'Enter' to return to the Character Selection Screen");
                Console.ReadLine();
                intro();

            }
            else if (yn2 == "y")
            {
                zylolevelUp();
            }
            else
            {
                Console.Write("Press 'Enter' to return to the Character Selection Screen");
                Console.ReadLine();
                intro();
            }

        }
        public void maxpromote()
        {
            if (maxunpro == true && maxlevel >= 10)

            {
                Console.WriteLine("Your character is ready to be promoted! Promote? y/n");
                string promoyn = Console.ReadLine();
                if (promoyn == "y")
                {
                    Console.WriteLine($"Congratulations! {maxcharaun} {maxchara}  has been promoted to the rank of {maxcharapro}!");
                    maxlevel = 1;
                    maxcharacterClass = maxcharapro;
                    maxunpro = false;
                    if (maxchara == "Max")
                    {
                        maxcanusemp = true;
                    }
                }
            }

        }
            public void zylopromote()
            {
                if (zylounpro == true && zylolevel >= 10)

                {
                    Console.WriteLine("Your character is ready to be promoted! Promote? y/n");
                    string promoyn = Console.ReadLine();
                    if (promoyn == "y")
                    {
                        Console.WriteLine($"Congratulations! {zylocharaun} {zylochara}  has been promoted to the rank of {zylocharapro}!");
                        zylolevel = 1;
                        zylocharacterClass = zylocharapro;
                        zylounpro = false;
                        
                    }
                }

            }

        }

}

     