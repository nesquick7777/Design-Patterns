using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuilder
{
    internal class Car
    {
        private String CarName { get; set; }
        private Engine CarEngine { get; set; }

        private TripComputer Computer { get; set; }

        private Seats CarSeats { get; set; }

        private Wheels CarWheels { get; set; }


        public Car(string name, Engine carEngine, TripComputer computer, Seats carSeats, Wheels carWheels)
        {
            CarName = name;
            CarEngine = carEngine;
            Computer = computer;
            CarSeats = carSeats;
            CarWheels = carWheels;
        }

        public override string ToString()
        {
            return CarName + ": \n\t Engine: " + CarEngine + " Computer: " + Computer + "Seats: " + CarSeats + "Wheels: " + CarWheels;
        }
    }
}
