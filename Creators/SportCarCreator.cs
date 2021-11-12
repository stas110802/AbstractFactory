using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrFactr
{
    public class SportCarCreator : Creator
    {
        public override Car Create()
        {
            return new SportCar();
        }
    }
}
