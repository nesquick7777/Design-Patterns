using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuilder
{
    internal class CarBuilder : Builder
    {
        private String name = "";
        private Engine engine;
        private TripComputer computer;
        private Seats seats;
        private Wheels wheels;
        public CarBuilder() { }

        public Car Build()
        {
            return new Car(name,engine,computer,seats,wheels);
        }

        public Builder BuildComputer(TripComputer computer)
        {
            this.computer = computer; return this;
        }

        public Builder BuildEngine(Engine Engine)
        {
            this.engine = Engine; return this;
        }

        public Builder BuildName(string Name)
        {
            this.name = Name; return this;
        }

        public Builder BuildSeats(Seats seats)
        {
            this.seats = seats; return this;
        }

        public Builder BuildWheels(Wheels wheels)
        {
            this.wheels = wheels; return this;
        }
    }
}
