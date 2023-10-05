using System;

namespace CarLotSimulator
{
    public class Car
    {
        private static int numberOfCars;

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }
        public string V1 { get; }
        public string V2 { get; }
        public int V3 { get; }

        public Car(int year, string make, string model, string enginenoise)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = enginenoise;
        }

        public Car(int year1, string make1)
        {
            Car.numberOfCars++;
        }

        public Car(string v1, string v2, int v3)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
        }

        public string MakeEngineNoise(string noise)
        {
            EngineNoise = noise;
            return EngineNoise;
        }

        public string MakeHonkNoise(string noise)
        {
            HonkNoise = noise;
            return HonkNoise;
        }

        public static int GetNumberOfCars()
        {
            return numberOfCars = 3;
        }
    }
}