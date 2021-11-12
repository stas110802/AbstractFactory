using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrFactr
{
    public class SportCar : Car
    {
        public SportCar(string model = null, int maxSpeed = 175, int velocity = 4)
        {
            Brand = "Спортивная";
            model ??= "Стандартная";
            Model = model;
            MaxSpeed = maxSpeed;
            Velocity = velocity;
        }
    }
}
