using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace CarLotSimulator
{
    public class Progam
    {

        //Create a seperate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable


        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property

       public static void Main()
        {
            Car car1 = new Car();
            car1.Year = 2021;
            car1.Make = "Subaru";
            car1.Model = "WRX";
            car1.IsDriveable = true;

            car1.MakeEngineNoise("loud whiny");
            car1.MakeHonkNoise("boop boop");

           


            Console.WriteLine(car1.EngineNoise);
            Console.WriteLine(car1.HonkNoise);
            Console.WriteLine("--------------");
       
            Car car2 = new Car() { Year = 2021, Make = "subaru", Model = "STI", IsDriveable = true };

            car2.MakeEngineNoise("too quiet");
            car2.MakeHonkNoise("weeeeeeeeee");


            Console.WriteLine(car2.EngineNoise);
            Console.WriteLine(car2.HonkNoise);
            Console.WriteLine("--------------");

            Car car3 = new Car(2021, "Mits", "EVO", "beep beep");

            car3.MakeEngineNoise("wrrrrrrrrrrrr");
            car3.MakeHonkNoise("beep beep");

            Console.WriteLine(car3.EngineNoise);
            Console.WriteLine(car3.HonkNoise);
            Console.WriteLine("-----------");
        }
            
        
            


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
}


