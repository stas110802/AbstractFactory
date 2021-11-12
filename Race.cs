using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrFactr
{
    public class Race
    {
        public Race()
        {
            _listOfCars = new();
            Distance = 8000;
        }
        public int Distance { get; set; }
        private List<Car> _listOfCars;
        private int _place = 1;

        public void AddCars(List<Car> listOfCars)
        {
            foreach (var car in listOfCars)
            {
                _listOfCars.Add(car);
            }
        }

        public void AddCar(Car car)
        {
            _listOfCars.Add(car);
        }

        public void StartRace()
        {

            while(_listOfCars.Count != 0)
            {
                foreach (var car in _listOfCars)
                {
                    car.MoveForward();// увеличиваем скорость
                    car.TotalDistance += car.TotalSpeed / 3.6m;// перевод из КМ/ч в М\С
                }

                while (Check()) { }
            }          
        }

        public bool Check()
        {
            foreach (var car in _listOfCars)
            {
                if (car.TotalDistance >= Distance)
                {
                    Console.WriteLine($"{car.Brand} {car.Model} на {_place} месте");
                    _place++;
                    _listOfCars.Remove(car);// если пересекли черту убираем машину

                    return true;
                }
            }

            return false;
        }
        public void PrintInfoAboutCars()
        {
            Console.WriteLine("Info about cars");

            foreach (var car in _listOfCars)
            {
                Console.WriteLine($"car {car.Brand} model {car.Model}");
            }
        }
    }
}
