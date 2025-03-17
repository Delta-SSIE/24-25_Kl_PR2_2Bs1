using Microsoft.EntityFrameworkCore;

namespace _06_DB_02_EF_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var dbContext = new MyDbContext();
            
            //select
            ListCars(dbContext);

            //insert
            var newCar = new Car() { 
                Brand = "Toyota", 
                Model = "Cellica", 
                Purchased = DateTime.Now, 
                RegPlate = "1A11234" 
            };
            dbContext.Cars.Add(newCar);
            dbContext.SaveChanges();

            ListCars(dbContext);


            //update
            newCar.RegPlate = "2B22345";
            dbContext.SaveChanges();

            ListCars(dbContext);


            //delete
            dbContext.Cars.Remove(newCar);
            dbContext.SaveChanges();

            ListCars(dbContext);

            //vyhledávání
            Console.WriteLine();
            var car2 = dbContext.Cars.FirstOrDefault(c => c.Model == "Mondeo");
            Console.WriteLine(car2.RegPlate);

            //výpis s řidiči
            foreach (var driver in dbContext.Drivers.Include(d => d.Car).ToList()) 
            {
                Console.WriteLine($"{driver.Surname} {driver.Name} : {driver.Car?.RegPlate}");
            }

        }

        private static void ListCars(MyDbContext dbContext)
        {
            foreach (var car in dbContext.Cars.ToList())
            {
                Console.WriteLine($"{car.Brand} {car.Model} ({car.RegPlate})");
            }
            Console.WriteLine();
        }
    }
}
