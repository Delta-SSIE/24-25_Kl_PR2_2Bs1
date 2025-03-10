using Microsoft.EntityFrameworkCore;

namespace _06_DB_03_EF_relations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var dbContext = new MyDbContext();

            foreach (var car in dbContext.Cars.ToList())
            {
                Console.WriteLine($"{car.Brand} {car.Model} ({car.RegPlate})");
            }
            Console.WriteLine();

            //foreach (var driver in dbContext.Drivers.ToList())
            //{
            //    Console.WriteLine($"{driver.Surname} {driver.Name} : {driver.Car?.RegPlate}");
            //}
        }
    }
}
