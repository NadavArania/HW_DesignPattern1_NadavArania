using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirgol_DesignPatterns
{
    enum atkinsMenu { eggs, fish, yellowCheese, chickenMeat }

    internal class AtkinsDiet : DietBase
    {
        atkinsMenu menu;

        public AtkinsDiet(int age, int weight, int height, atkinsMenu menu) : base(age, weight, height)
        {
            Age = age;
            Weight = weight;
            Height = height;
            this.menu = menu;
        }
    }
}
