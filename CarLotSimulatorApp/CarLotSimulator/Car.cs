using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator 
{ 
    public class Car
        {
        public int Year { get; set; }
        public string Make { get; set; }
           public string Model { get; set; }
           public string EngineNoise { get; set; }
           public string HonkNoise { get; set; }
       public bool IsDriveable { get; set; }

        public Car(int year, string make, string model, string enginenoise)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = enginenoise;


        }
        public Car() 
        {
            
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
        }
}
