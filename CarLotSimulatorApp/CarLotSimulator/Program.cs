using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            var vwMk4 = new Car();
            var bmvM5 = new Car();
            var isThatUhSupra = new Car();

            //Set the properties for each of the cars
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
            vwMk4.MakeEngineNoise(vwMk4.EngineNoise);
            vwMk4.MakeHonkNoise(vwMk4.HonkNoise);

            bmvM5.MakeEngineNoise(bmvM5.EngineNoise);
            bmvM5.MakeHonkNoise(bmvM5.HonkNoise);

            isThatUhSupra.MakeEngineNoise(isThatUhSupra.EngineNoise);
            isThatUhSupra.MakeHonkNoise(isThatUhSupra.HonkNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
