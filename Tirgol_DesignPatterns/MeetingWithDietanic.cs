using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirgol_DesignPatterns
{
    internal class MeetingWithDietanic
    {
        private IDietFactory dietFactory;

        private ChatingWithDietanic chatingWithDietanic;

        public MeetingWithDietanic(ChatingWithDietanic chatingWithDietanic)
        {
            this.chatingWithDietanic = chatingWithDietanic;
        }

        public void PersonSelectedVegDiet(vegMenu vm1, vegMenu vm2, vegMenu vm3, vegMenu vm4)
        {
            Console.WriteLine($"I recommend you to eat : {vm1} + {vm2} + {vm3} + {vm4}");
            dietFactory = new VegDietCreator();
        }

        public void PersonSelectedAtkinsDiet(atkinsMenu am1, atkinsMenu am2, atkinsMenu am3, atkinsMenu am4)
        {
            Console.WriteLine($"I recommend you to eat : {am1} + {am2} + {am3} + {am4}");
            dietFactory = new AtkinsDietCreator();
        }

        public void PersonSelectedPaleDiet(paleMenu pm1, paleMenu pm2, paleMenu pm3, paleMenu pm4)
        {
            Console.WriteLine($"I recommend you to eat : {pm1} + {pm2} + {pm3} + {pm4}");
            dietFactory = new PaleDietCreator();
        }

        public void UserAddToMenu(int age, int weight, int height)
        {
            if(dietFactory == null)
            {
                return;
            }

            DietBase db = dietFactory.CreateDiet(age, weight, height);
            chatingWithDietanic.GetMenu(db);
        }
    }
}
