using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirgol_DesignPatterns
{
    enum vegMenu { tomato, cucamber, melon, banana }

    internal class VegDiet : DietBase
    {
        vegMenu menu;

        public VegDiet(int age, int weight, int height, vegMenu menu) : base(age, weight, height)
        {
            Age = age;
            Weight = weight;
            Height = height;
            this.menu = menu;
        }
    }
}
