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
                $"\nBin Number {binWin(selectedRoulette, index)}\t{evenOddWin(selectedRoulette, index)}" +
                $"\t{colorWin(selectedRoulette, index)}\t{lowHighWin(selectedRoulette, index)}\t{dozensWin(selectedRoulette, index)} +
                $"\n{columnsWin(selectedRoulette, index)}\t{streetWin(selectedRoulette, index)}\t{sixNumberWin(selectedRoulette, index)}" +
                $"\t{splitWin(selectedRoulette, index)}\t{cornerWin(selectedRoulette, index)}");
        }

        public int binWin((string, string) arrayValue, int n)
        {
            return n;
        }

        public int evenOddWin((string, string) arrayValue, int n)
        {

        }

        public void colorWin((string, string) arrayValue, int n)
        {

        }

        public void lowHighWin()
        {

        }

        public void dozensWin()
        {

        }

        public void columnsWin()
        {

        }

        public void streetWin()
        {

        }

        public void sixNumberWin()
        {

        }

        public void splitWin()
        {

        }

        public void cornerWin()
        {

        }
    }
}
