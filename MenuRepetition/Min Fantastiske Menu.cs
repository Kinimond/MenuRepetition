using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuRepetition
{
    internal class Min_Fantastiske_Menu
    {

        public static void MinFantastiskeMenu()
        {

            string menu = "Min Fantastiske menu: \n 1. Gør dit \n 2. Gør dat \n 3. Gør noget \n 4. Få svaret på livet, universet og alting \n \n(Tryk på menupunkt 1, 2, 3 eller 4)";
            Console.WriteLine(menu);

            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Du gjorde dit");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Du gjorde dat");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Du gjorde noget");
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Du fik svaret på livet, universet og alting");
                    break;
                default:
                    Console.WriteLine("DU ER DØD");
                    break;
            }


        }
    }
}

