using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrFactr
{
    public class RacingCar : Car
    {
        public RacingCar(string model = null, int maxSpeed = 220, int velocity = 5)
        {
            Brand = "Гоночная";
            model ??= "Стандартная";
            Model = model;
            MaxSpeed = maxSpeed;
            Velocity = velocity;
        }
    }
}
