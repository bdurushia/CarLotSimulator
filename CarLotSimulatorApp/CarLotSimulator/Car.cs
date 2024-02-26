﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a seperate class file called Car




namespace CarLotSimulator
{
    public class Car
    {
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        public int Year {  get; set; }
        public string Make {  get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property
        public void MakeEngineNoise(string EngineNoise)
        {
            Console.WriteLine($"{Make}: {EngineNoise}");
        }

        public void MakeHonkNoise(string HonkNoise)
        {
            Console.WriteLine($"{Make}: {HonkNoise}");
        }
        
    }
}