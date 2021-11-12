using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrFactr
{
    public abstract class Creator
    {
        public abstract Car Create();

        public void Log()
        {
            var car = Create();
            Console.WriteLine($"This is {car.Brand} model {car.Model}");
        }
    }
}
