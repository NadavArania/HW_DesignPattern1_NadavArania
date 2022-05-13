using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirgol_DesignPatterns
{
    internal class GarageDiagnosticCheckHandler : CarHandler
    {
        public override void RepairRequestHandler()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 10);

            if (randomNumber >= 6)
            {
                carChecker = true;
                Console.WriteLine("Your Car is Fixed and approved by the diagnostic checker!");
            }

            if (randomNumber < 6)
            {
                carChecker = false;

                if (next == null)
                {
                    Console.WriteLine("Your car cannot be fixed!");
                }
            }
        }
    }
}
