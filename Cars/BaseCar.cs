using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrFactr
{
    public class BaseCar : Car
    {
        public BaseCar(string model = null, int maxSpeed = 80, int velocity = 2)
        {
            Brand = "Автобус";
            model ??= "Стандартная";
            Model = model;
            MaxSpeed = maxSpeed;
            Velocity = velocity;         
        }
    }
}
