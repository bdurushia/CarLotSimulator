using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            var carsAvailable = new CarLot();

            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            var vwMk4 = new Car();
            CarLot.NumberOfCars++;  // Count new car creation and add to Number of Cars, 
            Console.WriteLine($"Car Added to Lot! Total number of cars in Lot: {CarLot.NumberOfCars}"); // then print

            var bmvM5 = new Car();
            CarLot.NumberOfCars++;
            Console.WriteLine($"Car Added to Lot! Total number of cars in Lot: {CarLot.NumberOfCars}");

            var isThatUhSupra = new Car();
            CarLot.NumberOfCars++;
            Console.WriteLine($"Car Added to Lot! Total number of cars in Lot: {CarLot.NumberOfCars}");

            //Set the properties for each of the cars
            // Using Dot notation here for all
            vwMk4.Year = 2003;
            vwMk4.Make = "Volkswagen";
            vwMk4.Model = "Jetta Sportwagen TDI";
            vwMk4.EngineNoise = "Brrpp djuh djuh djuh djuh djuh";
            vwMk4.HonkNoise = "(quiet) - honk.";
            vwMk4.IsDriveable = true;

            bmvM5.Year = 2016;
            bmvM5.Make = "BMW";
            bmvM5.Model = "F11 M5 Estate Wagon";
            bmvM5.EngineNoise = "SSSssswwwuu rrrrrrRRRR CRACKPOPOP";
            bmvM5.HonkNoise = "(two-tone) HONK!!";
            bmvM5.IsDriveable = true;

            isThatUhSupra.Year = 1982;
            isThatUhSupra.Make = "Toyota";
            isThatUhSupra.Model = "Celica Supra";
            isThatUhSupra.EngineNoise = "bbrrrrrrpprprppp stu-stu-stu";
            isThatUhSupra.HonkNoise = "beep-beep";
            isThatUhSupra.IsDriveable = true;

            //Call each of the methods for each car
            Console.WriteLine("\n(Call Methods for Each of the 3 cars and their noises)\n");
            vwMk4.MakeEngineNoise(vwMk4.EngineNoise);
            vwMk4.MakeHonkNoise(vwMk4.HonkNoise);

            Console.WriteLine("\n---------------------------------\n"); // Spacing for console view

            bmvM5.MakeEngineNoise(bmvM5.EngineNoise);
            bmvM5.MakeHonkNoise(bmvM5.HonkNoise);

            Console.WriteLine("\n---------------------------------\n"); // Spacing for console view

            isThatUhSupra.MakeEngineNoise(isThatUhSupra.EngineNoise);
            isThatUhSupra.MakeHonkNoise(isThatUhSupra.HonkNoise);

            Console.WriteLine("\n=================================\n"); // Spacing for console view

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            // More cars created
            // Using Object Initializer Syntax
            var vwGolf = new Car()
            {
                Year = 2012,
                Make = "Volkswagen",
                Model = "Golf TDI",
                EngineNoise = "SSSssswwuu djehdjehdjehdjehdjeh",
                HonkNoise = "honkkk",
                IsDriveable = true
            };

            CarLot.NumberOfCars++;
            Console.WriteLine($"Car Added to Lot! Total number of cars in Lot: {CarLot.NumberOfCars}");

            // Using Custom constructor (overlading)
            var fordFocus = new Car(2012, "Ford", "Focus", "nehh theh theh clunk chck stih schunk", "beep", false);

            CarLot.NumberOfCars++;
            Console.WriteLine($"Car Added to Lot! Total number of cars in Lot: {CarLot.NumberOfCars}");

            // Using Dot notation for this one
            var skodaOct = new Car();

            skodaOct.Year = 2024;
            skodaOct.Make = "Skoda";
            skodaOct.Model = "Octavia TDI";
            skodaOct.EngineNoise = "druh druh druh druh";
            skodaOct.HonkNoise = "BEEEEEEP";
            skodaOct.IsDriveable = true;

            CarLot.NumberOfCars++;
            Console.WriteLine($"Car Added to Lot! Total number of cars in Lot: {CarLot.NumberOfCars}");

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            carsAvailable.CarList.Add(vwMk4);
            carsAvailable.CarList.Add(bmvM5);
            carsAvailable.CarList.Add(isThatUhSupra);
            carsAvailable.CarList.Add(vwGolf);
            carsAvailable.CarList.Add(fordFocus);
            carsAvailable.CarList.Add(skodaOct);

            carsAvailable.PrintAllCars();

        }
    }
}
