using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette2017
{
    class Program
    {
        static void Main(string[] args)
        {
            RouletteMethods runRoulette = new RouletteMethods();
            Random rand = new Random();
            runRoulette.outputVictors(rand);
        }
    }
}
