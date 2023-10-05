using CarLotSimulator;
using System;

public class Program
{
    public static void Main()
    {
        Car car1 = new Car(2022, "Toyota", "Camry", "Vroom");
        Car car2 = new Car(2021, "Honda", "Civic", "Rumble");
        Car car3 = new Car("custom", "", 2023);

        // Display car details
        Console.WriteLine("\nCar Details:");
        Console.WriteLine("Car 1:");
        Console.WriteLine($"Year: {car1.Year}");
        Console.WriteLine($"Make: {car1.Make}");
        Console.WriteLine($"Model: {car1.Model}");
        Console.WriteLine($"Engine Noise: {car1.EngineNoise}");

        Console.WriteLine("\nCar 2:");
        Console.WriteLine($"Year: {car2.Year}");
        Console.WriteLine($"Make: {car2.Make}");
        Console.WriteLine($"Model: {car2.Model}");
        Console.WriteLine($"Engine Noise: {car2.EngineNoise}");

        Console.WriteLine("\nCar 3:");
        Console.WriteLine($"Make: {car3.Make}");
        Console.WriteLine($"Model: {car3.Model}");
        Console.WriteLine($"V3: {car3.V3}");

        // Display the number of cars
        Console.WriteLine($"\nNumber of Cars: {Car.GetNumberOfCars()}");
    }
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




