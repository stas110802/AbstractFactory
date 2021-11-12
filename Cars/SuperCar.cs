using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrFactr
{
    public class SuperCar : Car
    {
        public SuperCar(string model = null, int maxSpeed = 150, int velocity = 3)
        {
            Brand = "Супер";
            model ??= "Стандартная";
            Model = model;
            MaxSpeed = maxSpeed;
            Velocity = velocity;
        }
    }
}
