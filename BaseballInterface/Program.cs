using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var metal = new AluminumBat();
            var wood = new WoodenBat();
            var composite = new CompositeBat();

            var who = new BaseballPlayer();

            who.TakeTurn(metal);
            who.TakeTurn(wood);
            who.TakeTurn(composite);
        }
    }
}
