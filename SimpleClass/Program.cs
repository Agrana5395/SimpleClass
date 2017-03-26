using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please tell me the year of your car");
            int year = Convert.ToInt16(Console.ReadLine());

            Car myCar = new Car();
            decimal value = DetermineMarketValue(myCar);
            myCar.Make = "Oldsmobile";
            myCar.Make = "Cutlas Supreme";
            myCar.Year = year;
            myCar.Color = "Sylver";

            Console.WriteLine(" {0} {1} {2} {3} ",
               myCar.Make,
               myCar.Model,
               myCar.Year,
               myCar.Color);
      
            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());


            Car myCar3 = new Car("Tesla", "S model", year, "Red");
            decimal valueCar3 = DetermineMarketValue(myCar3);
            Console.WriteLine("The new car is {0} from  {1}, and cost just {2:C}",
                myCar3.Model, myCar3.Year, myCar3.DetermineMarketValue());


            

            //Car myCar2 = new Car();
            //myCar2 = myCar;
            //myCar2.Model = "V4c";
            //Console.WriteLine("The second car change the model {0}", myCar2.Model);
            //Console.WriteLine("--------------------------");


            // I Did comment out the objects in orther to test the new constructor in class Car
            //please, make sure you remove the constructor in  the Car Class if you uncoment (above code)

           
               Console.ReadLine();


            

        }

        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 100.0M;

            return carValue;
        }
    }

}
