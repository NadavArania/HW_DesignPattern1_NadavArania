using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirgol_DesignPatterns
{
    interface IDietFactory
    {
        public abstract DietBase CreateDiet(int age, int weight, int height);
    }
}
