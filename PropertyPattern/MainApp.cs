using System;




namespace PropertyPattern
{
    class Car
    {
        public string Model {get; set;}
        public DateTime ProducedAt { get; set;}

    }

    static string GetNickname(Car car)
    {
        var GenerateMessage = (Car car, string nickname) =>
            $"{car.Model} produced in {car.ProducedAt.Year} is {nickname}";

            if (car is Car { Model: "Mustang", ProducedAt.Year: 1967 })
                return GenerateMessage(car, "Fastback");
            else if (car is Car { Model: "Mustang", ProducedAt.Year: 1976 })
                return GenerateMessage(car, "Cobra II");

    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
