using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuilder
{
    internal interface Builder
    {
        Builder BuildName(String Name);
        Builder BuildEngine(Engine Engine);
        Builder BuildComputer(TripComputer computer);

        Builder BuildSeats(Seats seats);

        Builder BuildWheels(Wheels wheels);
    }
}
