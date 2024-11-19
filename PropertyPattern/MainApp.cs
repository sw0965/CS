using System;
using System.Xml.Schema;




namespace PropertyPattern
{
    class Car
    {
        public string ?Model { get; set; }
        public DateTime ProducedAt { get; set; }

    

    static string GetNickname(Car car)
        {
            var GenerateMessage = (Car car, string nickname) =>
                $"{car.Model} produced in {car.ProducedAt.Year} is {nickname}";

            // switch 문으로 변환하기
            //if (car is Car { Model: "Mustang", ProducedAt.Year: 1967 })
            //    return GenerateMessage(car, "Fastback");
            //else if (car is Car { Model: "Mustang", ProducedAt.Year: 1976 })
            //    return GenerateMessage(car, "Cobra II");
            //else
            //    return GenerateMessage(car, "Unknow");

            // 보류
            //string year = car.ProducedAt.Year switch
            //{
            //    1967 => "Fastback",
            //    1976 => "Cobra II",
            //    _ => "Unknow"
            //};

            // switch 문으로 변환 작업 완료
            switch (car.Model)
            {
                case "Mustang" when car.ProducedAt.Year == 1967:
                    return GenerateMessage(car, "Fastback");

                case "Mustang" when car.ProducedAt.Year == 1976:
                    return GenerateMessage(car, "Cobra II");
                    
                default:
                    return GenerateMessage(car, "Unknow");
                    
            }
            

        }
        //class MainApp

        static void Main(string[] args)
        {
            Console.WriteLine(
                GetNickname(
                    new Car() { Model = "Mustang", ProducedAt = new DateTime(1967, 11, 23) }));

            Console.WriteLine(
                GetNickname(
                    new Car() { Model = "Mustang", ProducedAt = new DateTime(1976, 6, 7) }));

            Console.WriteLine(
                GetNickname(
                    new Car() { Model = "Mustang", ProducedAt = new DateTime(2099, 12, 25) }));
        }

    }
}
