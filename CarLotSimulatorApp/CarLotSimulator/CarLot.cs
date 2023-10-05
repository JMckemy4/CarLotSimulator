using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    public class CarLot
    {
        public static int numberOfCars;


        // A list to store the cars in the car lot
        public List<Car> carList { get; set; } = new List<Car>();

    }
}



//        Inside the CarLot class from the previous exercise, create a static field called numberOfCars.
//        Have this number only increment when in our program we create a new Car.
//        From there, use the 3 cars in the Main() (from the previous exercise) and then each time you create a car do a 
//        Console.WriteLine()
//        printing the current number of cars in the car lot.


