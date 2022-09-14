using System.Numerics;

namespace OOPDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car carListOne = new Car();
            carListOne.Make = "Volkswagen";
            carListOne.Color = "Blue";

            Car carListTwo = new Car();
            carListTwo.Make = "Dodge";
            carListTwo.Color = "Red";

            carListOne.PrintCarInfo();

            ////Skapa listor
            //var cars = new List<Car>();

            //for (int i = 0; i < 21; i++)
            //{
            //    var car = new Car();
            //    car.Make = $"{i}";
            //    car.Color = $"{i}";
            //    cars.Add(car);
            //}

            //foreach (var item in cars)
            //{
            //    item.PrintCarInfo();
            //}
        }
    }
}