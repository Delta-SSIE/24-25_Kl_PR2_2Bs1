namespace _03_OOP3_09_Randomizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1, 2, 3, 4, 5, 6, 7];
            //Randomizer randomizer = new Randomizer(nums);
            GenericRandomizer<int> randomizer = new GenericRandomizer<int>(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"Další číslo je {randomizer.Next()}");
            }

            string[] people = ["Anna", "Marie", "Kateřina", "Eliška"];
            GenericRandomizer<string> randomizer2 = new GenericRandomizer<string>(people);

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"Další osoba je {randomizer2.Next()}");
            }
        }
    }
}
