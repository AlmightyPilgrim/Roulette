using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette2017
{
    class RouletteMethods
    {
        public (string, string)[] rouletteArray = new (string, string)[38]
       {
            ("0", "green"), ("1", "red"), ("2", "black"), ("3", "red"), ("4", "black"), ("5", "red"),
            ("6", "black"), ("7", "red"), ("8", "black"), ("9", "red"), ("10", "black"), ("11", "black"),
            ("12", "red"), ("13", "black"), ("14", "red"), ("15", "black"), ("16", "red"), ("17", "black"),
            ("18", "red"), ("19", "red"), ("20", "black"), ("21", "red"), ("22", "black"), ("23", "red"),
            ("24", "black"), ("25", "red"), ("26", "black"), ("27", "red"), ("28", "black"), ("29", "black"),
            ("30", "red"), ("31", "black"), ("32", "red"), ("33", "black"), ("34", "red"), ("35", "black"),
            ("36", "red"), ("00", "green")
       };

        public (string, string) selectedRoulette { get; set; }

        public int selectedNumber { get; set; }

        public void outputVictors(Random ranNumber)
        {
            // index is to be able to use the index without changing the value, or worry about changes in program
            int index = ranNumber.Next(38);
            // getting the winning roulette from a random number based from index
            selectedRoulette = rouletteArray.ElementAt(index);

            Console.WriteLine($"The winning number is {selectedRoulette}");
            Console.WriteLine($"Winning bets are as follows:" +
                $"\n{binWin(selectedRoulette, index)}\t{evenOddWin(selectedRoulette, index)}" +
                $"\t{colorWin(selectedRoulette, index)}\t{lowHighWin(selectedRoulette, index)}\t{dozensWin(selectedRoulette, index)}" +
                $"\n{columnsWin(selectedRoulette, index)}\t{streetWin(selectedRoulette, index)}\t{sixNumberWin(selectedRoulette, index)}" +
                $"\t{splitWin(selectedRoulette, index)}\t{cornerWin(selectedRoulette, index)}");
        }

        public int binWin((string, string) arrayValue, int n)
        {
            Console.WriteLine($"Bin: {arrayValue.Item1}"); 
            return n;
        }

        public int evenOddWin((string, string) arrayValue, int n)
        {            
            if (n % 2 == 0)
            {
                Console.WriteLine("Evens win");
            }
            else
            {
                Console.WriteLine("Odds win");
            }
            return n;
        }

        public int colorWin((string, string) arrayValue, int n)
        {
            Console.WriteLine($"Color: {arrayValue.Item2}");
            return n;
        }

        public int lowHighWin((string, string) arrayValue, int n)
        {
            if ((1 <= n) && (n <= 18))
            {
                Console.WriteLine("Lows win");
            }
            else if ((19 <= n) && (n <= 36))
            {
                Console.WriteLine("Highs win");
            }
            else
            {
                Console.WriteLine("House wins");
            }
            return n;
        }

        public int dozensWin((string, string) arrayValue, int n)
        {
            if ((1 <= n) && (n <= 12))
            {
                Console.WriteLine("First dozen win");
            }
            else if ((13 <= n) && (n <= 24))
            {
                Console.WriteLine("Second dozen win");
            }
            else if ((25 <= n) && (n <= 36))
            {
                Console.WriteLine("Third dozen win");
            }
            else
            {
                Console.WriteLine("House wins");
            }
            return n;
        }

        public int columnsWin((string, string) arrayValue, int n)
        {
            if ((n == 1) || (n == 4) || (n == 7) || (n == 10) || (n == 13) || (n == 16) ||
                 (n == 19) || (n == 22) || (n == 25) || (n == 28) || (n == 31) || (n == 34))
            {
                Console.WriteLine("Column 1 wins");
            }
            else if ((n == 2) || (n == 5) || (n == 8) || (n == 11) || (n == 14) || (n == 17) ||
                 (n == 20) || (n == 23) || (n == 26) || (n == 29) || (n == 32) || (n == 35))
            {
                Console.WriteLine("Column 2 wins");
            }
            else if ((n == 3) || (n == 6) || (n == 9) || (n == 12) || (n == 15) || (n == 18) ||
                 (n == 21) || (n == 24) || (n == 27) || (n == 30) || (n == 33) || (n == 36))
            {
                Console.WriteLine("Colum 3 wins");
            }
            else
            {
                Console.WriteLine("House wins");
            }
                return n;
        }

        public int streetWin((string, string) arrayValue, int n)
        {
            // try to find a way to not have if statement here
            // thought process is there, implementation off
            if ((n == 1) || (n == 2) || (n == 3))
            {
                Console.WriteLine("Street 1, 2, 3 wins");
            }
            else if ((n == 4) || (n == 5) || (n == 6))
            {
                Console.WriteLine("Street 4, 5, 6 wins");
            }
            else if ((n == 7) || (n == 8) || (n == 9))
            {
                Console.WriteLine("Street 7, 8, 9 wins");
            }
            else if ((n == 10) || (n == 11) || (n == 12))
            {
                Console.WriteLine("Street 10, 11, 12 wins");
            }
            else if ((n == 13) || (n == 14) || (n == 15))
            {
                Console.WriteLine("Street 13, 14, 15 wins");
            }
            else if ((n == 16) || (n == 17) || (n == 18))
            {
                Console.WriteLine("Street 16, 17, 18 wins");
            }
            else if ((n == 19) || (n == 20) || (n == 21))
            {
                Console.WriteLine("Street 19, 20, 21 wins");
            }
            else if ((n == 22) || (n == 23) || (n == 24))
            {
                Console.WriteLine("Street 22, 23, 24 wins");
            }
            else if ((n == 25) || (n == 26) || (n == 27))
            {
                Console.WriteLine("Street 25, 26, 27 wins");
            }
            else if ((n == 28) || (n == 29) || (n == 30))
            {
                Console.WriteLine("Street 28, 29, 30 wins");
            }
            else if ((n == 31) || (n == 32) || (n == 33))
            {
                Console.WriteLine("Street 31, 32, 33 wins");
            }
            else if ((n == 34) || (n == 35) || (n == 36))
            {
                Console.WriteLine("Street 34, 35, 36 wins");
            }
            else
            {
                Console.WriteLine("House wins 0, 00");
            }
            return n;
        }

        public int sixNumberWin((string, string) arrayValue, int n)
        {
            if (( 1 <= n) && (n <= 6))
            {

            }
            else if ((4 <= n) && (n <= 9))
            {

            }
            else if ((7 <= n) && (n <= 12))
            {

            }
            else if ((10 <= n) && (n <= 15))
            {

            }
            else if ((13 <= n) && (n <= 18))
            {

            }
            else if ((16 <= n) && (n <= 21))
            {

            }
            else if ((19 <= n) && (n <= 24))
            {

            }
            else if ((22 <= n) && (n <= 27))
            {

            }
            else if ((25 <= n) && (n <= 27))
            {

            }
            else if ((28 <= n) && (n <= 27))
            {

            }
            else if ((31 <= n) && (n <= 36))
            {

            }
            else
            {
                Console.WriteLine("House wins");
            }
            return n;
        }

        public int splitWin((string, string) arrayValue, int n)
        {
            // switch statement with case for each number available
            // will be redundant
            switch (n)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                case 21:
                    break;
                case 22:
                    break;
                case 23:
                    break;
                case 24:
                    break;
                case 25:
                    break;
                case 26:
                    break;
                case 27:
                    break;
                case 28:
                    break;
                case 29:
                    break;
                case 30:
                    break;
                case 31:
                    break;
                case 32:
                    break;
                case 33:
                    break;
                case 34:
                    break;
                case 35:
                    break;
                case 36:
                    break;
                default:
                    break;
            }
            return n;
        }

        public int cornerWin((string, string) arrayValue, int n)
        {
            if ((n == 0) || (n == 37))
            {

            }
            else
            {
                // taking column method and applying it to corners, gonna be redundant code
                if ((n == 1) || (n == 4) || (n == 7) || (n == 10) || (n == 13) || (n == 16) ||
                     (n == 19) || (n == 22) || (n == 25) || (n == 28) || (n == 31) || (n == 34))
                {

                }
                else if ((n == 2) || (n == 5) || (n == 8) || (n == 11) || (n == 14) || (n == 17) ||
                     (n == 20) || (n == 23) || (n == 26) || (n == 29) || (n == 32) || (n == 35))
                {

                }
                else if ((n == 3) || (n == 6) || (n == 9) || (n == 12) || (n == 15) || (n == 18) ||
                     (n == 21) || (n == 24) || (n == 27) || (n == 30) || (n == 33) || (n == 36))
                {

                }
                else
                {

                }
            }
            
            return n;
        }
    }
}
