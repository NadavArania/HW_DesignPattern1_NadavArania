using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirgol_DesignPatterns
{
    internal class ChatingWithDietanic
    {
        public void GetMenu(DietBase db)
        {
            Console.WriteLine($"Your details are : Age - {db.Age}, Height - {db.Height}, Weight - {db.Weight}");
        }
    }
}
