using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magnet2
{
    internal class Space
    {
        Random rnd = new Random();
        string[] spaceShip = {
            "                  !???J~",
            "                ^P5J~:!PJ",
            "               ~B7~7.:.:P?",
            "            :J?B!^777777~PJJ7",
            "           .J&&7^Y^::::~Y~B&B7.",
            "           :#&J:5~^~~~~^!Y!#&#:  ",
            "           .BP.7Y????7???5^?&P",
            "           ?#^!^.:......:::.5P  ",
            "   ?!     ^#?!Y::::::::::.^~:G5   ",
            "  ?&BYY:  PB:!:::.~GGG~.:777^~&! .^^Y?.",
            "  G&#YYB. P#^^~::.Y#YBG:^??7:!B.:PBB&&G. ",
            " .B##G?B. ~&5^5:::BGYY#J^?7~:B7 ?GY&BG&Y   ",
            " :#BB&GB.  Y&!~:.7#5Y5B#~77:YP  ~GBBGG#B.    ",
            " ^#BPB##^  .BB::.5BYYYP#5:^!#^  !#BGGP##:     ",
            " :#BPPGBBY~ ~&Y.:BPYY5PB#~.GJ ^YBGPGGGB#:     ",
            " :#BPGGPGB#^ ?&!:BPYY5P#B:JG 7#BGPGGBG#G.     ",
            "  G#GGGGGP#P!!BG:?#YYYG&J~#5J##PGGGBGG&J      ",
            "  ?&GPGGGGB#&&#&J:BPYYG#~P&&&#GGGBBGG#G.      ",
            "   Y#BGBBBBB##B#&!7#YY#YJ&&##BGBBGBB#P:       ",
            "    ^JPG####&J.^BBY#GG#PB77G&BB##BG5!         ",
            "       .:~~!~:  :7BYYYBJ:  ^777!~:.           ",
            "                  ??77J.};"
        };
        string GoOption = "\n[1] - Go!";
        string exitOption = "\n[2] - Exit.";
        string choose = "";
        int score;
        bool IM1, IGO1, IEO1, ISC1;

        public void game(bool IM, bool ISC, bool IGO, bool IEO)
        {
            for (int i = 0; i <= spaceShip.Length-1; i++)
            {
                Console.WriteLine(spaceShip[i]);
                Thread.Sleep(250);
            }
            menu(IM, ISC, IGO, IEO);
        }

        void menu(bool IM, bool ISC, bool IGO, bool IEO)
        {
            IM1 = IM;
            ISC1 = ISC;
            IGO1 = IGO;
            IEO1 = IEO;
            if (IM)
            {
                if (ISC == true)
                    Console.WriteLine("\nYour score is: " + score);
                if (IGO == true)
                    Console.WriteLine(GoOption);
                if (IEO == true) 
                    Console.WriteLine(exitOption);
            }
            choose = Console.ReadLine();
            if (choose == "1")
            {
                if(rnd.Next(1, 3) == 2)
                    Fight();
                else if (rnd.Next(1, 3) == 1){
                    Console.WriteLine("\nAll is good...");
                    menu(IM1, ISC1, IGO1, IEO1);
                }
            }
            else { }
        }
        void Fight() {
            Console.WriteLine("\nFight!");
            if (rnd.Next(1, 3) == 2){
                if (ISC1 == false)
                    Console.Write("You win!");
                else
                    Console.WriteLine("+20 score!");
                score = score + 20;
            }
            else if (rnd.Next(1, 3) == 1 || rnd.Next(1, 3) == 3) {
                if (ISC1 == false)
                    Console.Write("You lose!");
                else
                    Console.WriteLine("-10 score");
                score = score - 10;
            }
            menu(IM1, ISC1, IGO1, IEO1);
        }
    }
}