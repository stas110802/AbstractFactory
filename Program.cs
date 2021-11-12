using System;
using System.Collections.Generic;

namespace abstrFactr
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Car>()
            {
                new BaseCarCreator().Create(),                     
                new SportCarCreator().Create(),
                new RacingCarCreator().Create(),
                new SuperCarCreator().Create()
            };

            var race = new Race();
            race.AddCars(list);
            race.PrintInfoAboutCars();
            race.StartRace();
        }
    }
}
