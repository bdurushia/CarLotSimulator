using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        // Property (List of Cars)
        public List<Car> CarList { get; set; } = new List<Car>();

        public void PrintAllCars()
        {
            Console.WriteLine("\n----Cars Available in Car Lot----\n");

            foreach (var car in CarList) 
            {
                //car.CarSpec(car.Year, car.Make, car.Model);
                Console.WriteLine($"Year:\t{car.Year}\nMake:\t{car.Make}\nModel:\t{car.Model}");

                Console.WriteLine("\n---------------------------------\n");
            }
        }
    }
}

//*************BONUS X 2*************//

//Create a CarLot class
//It should have at least one property: a List of cars
//Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
//At the end iterate through the list printing each of car's Year, Make, and Model to the console