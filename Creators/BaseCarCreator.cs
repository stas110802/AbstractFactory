using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrFactr
{
    public class BaseCarCreator : Creator
    {
        public override Car Create()
        {
            return new BaseCar();
        }
    }
}
