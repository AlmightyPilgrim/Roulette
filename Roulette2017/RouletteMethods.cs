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
                Console.WriteLine("Street 1, 2, 3 wins");
            }
            else if ((n == 7) || (n == 2) || (n == 3))
            {
                Console.WriteLine("Street 1, 2, 3 wins");
            }
            else if ((n == 10) || (n == 2) || (n == 3))
            {
                Console.WriteLine("Street 1, 2, 3 wins");
            }
            else if ((n == 13) || (n == 2) || (n == 3))
            {
                Console.WriteLine("Street 1, 2, 3 wins");
            }
            else if ((n == 16) || (n == 2) || (n == 3))
            {
                Console.WriteLine("Street 1, 2, 3 wins");
            }
            else if ((n == 19) || (n == 2) || (n == 3))
            {
                Console.WriteLine("Street 1, 2, 3 wins");
            }
            else if ((n == 22) || (n == 2) || (n == 3))
            {
                Console.WriteLine("Street 1, 2, 3 wins");
            }
            else if ((n == 25) || (n == 2) || (n == 27))
            {
                Console.WriteLine("Street 1, 2, 3 wins");
            }
            else if ((n == 28) || (n == 29) || (n == 30))
            {
                Console.WriteLine("Street 1, 2, 3 wins");
            }
            else if ((n == 31) || (n == 32) || (n == 33))
            {
                Console.WriteLine("Street 1, 2, 3 wins");
            }
            else if ((n == 34) || (n == 35) || (n == 36))
            {
                Console.WriteLine("Street 1, 2, 3 wins");
            }
            else
            {
                Console.WriteLine("House wins 0, 00");
            }
            return n;
        }

        public int sixNumberWin((string, string) arrayValue, int n)
        {
            return n;
        }

        public int splitWin((string, string) arrayValue, int n)
        {
            return n;
        }

        public int cornerWin((string, string) arrayValue, int n)
        {
            // taking column method and applying it to corners, gonna be redundant code
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
            if ((n == 0) || (n == 37))
            {
                Console.WriteLine("House wins");
            }
            else
            {
                
            }
            return n;
        }
    }
}
