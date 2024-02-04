using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuilder
{
    internal class Director
    {
    
        public void ConstructPorsche(Builder builder) { builder.BuildWheels(new Wheels()).BuildEngine(new Engine()).BuildComputer(new TripComputer()).BuildName("Porsche_911").BuildSeats(new Seats()); }

        public void ConstructYugo(Builder builder) { builder.BuildWheels(new Wheels()).BuildEngine(new Engine()).BuildComputer(new TripComputer()).BuildName("Yugo_Koral_45").BuildSeats(new Seats()); }
    }
}
