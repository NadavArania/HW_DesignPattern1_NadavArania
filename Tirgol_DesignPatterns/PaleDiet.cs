using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirgol_DesignPatterns
{
    enum paleMenu { brocoli, carrot, salamonFish, waterMelon}

    internal class PaleDiet : DietBase
    {
        paleMenu menu;

        public PaleDiet(int age, int weight, int height, paleMenu menu) : base(age, weight, height)
        {
            Age = age;
            Weight = weight;
            Height = height;
            this.menu = menu;
        }
    }
}
