using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    class Car
    {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }

        public decimal DetermineMarketValue()
        {
            decimal carValue;
            if (Year > 1990)
            {
                carValue = 11000;
            }
            else
            {
                carValue = 200;
            }
            return carValue;
        }
       
        // The constructor.
        public Car()
        {
            //youn could load from a config file or a database
            this.Make = "Nissan";
        }

        public Car(string make, string model, int year, string color)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Color = color;

        }
    }
}
