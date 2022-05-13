using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirgol_DesignPatterns
{
    internal class VegDietCreator : IDietFactory
    {
        readonly vegMenu menu;
        public DietBase CreateDiet(int age, int weight, int height)
        {
            return new VegDiet(age, weight, height, menu);
        }
    }

    internal class AtkinsDietCreator : IDietFactory
    {
        readonly atkinsMenu menu;
        public DietBase CreateDiet(int age, int weight, int height)
        {
            return new AtkinsDiet(age, weight, height, menu);
        }
    }

    internal class PaleDietCreator : IDietFactory
    {
        readonly paleMenu menu;
        public DietBase CreateDiet(int age, int weight, int height)
        {
            return new PaleDiet(age, weight, height, menu);
        }
    }
}
