using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrFactr
{
    public abstract class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int TotalSpeed { get; set; } = 0;
        public int MaxSpeed { get; set; }
        public int Velocity { get; set; }
        public decimal TotalDistance { get; set; } = 0;

        public virtual void MoveForward()
        {
            if(TotalSpeed < MaxSpeed)
            {
                TotalSpeed += Velocity;
            }
        }
        public virtual void MoveBack()
        {
            if(TotalSpeed > 0)
            {
                TotalSpeed -= Velocity;
            }
        }
    }
}
