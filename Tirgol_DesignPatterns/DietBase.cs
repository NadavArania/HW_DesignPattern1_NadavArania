using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirgol_DesignPatterns
{
    internal abstract class DietBase
    {
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

        public DietBase(int age, int weight, int height)
        {
            Age = age;
            Weight = weight;
            Height = height;
        }
    }
}
