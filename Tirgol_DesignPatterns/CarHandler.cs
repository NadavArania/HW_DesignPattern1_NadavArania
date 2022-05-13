using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirgol_DesignPatterns
{
    internal abstract class CarHandler
    {
        protected CarHandler next;
        public bool carChecker;

        public CarHandler()
        {

        }

        public void SetNext(CarHandler nextTreatment)
        {
            next = nextTreatment;
        }

        public abstract void RepairRequestHandler();
    }
}
