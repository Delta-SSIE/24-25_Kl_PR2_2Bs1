
namespace _00_Rev_01_StatistikaPodLimitem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double[] cisla = { 1.3, 2.2, -1.5, 1.4, -2.7 };
            Console.WriteLine(PrumerPodLimitem(cisla, 1.1)); //vypíše -2.1
            Console.WriteLine(PrumerPodLimitem(cisla, -2)); //vypíše -2.7
            Console.WriteLine(PrumerPodLimitem(cisla, 3)); //vypíše 0.14
        }

        private static double PrumerPodLimitem(double[] cisla, double limit) => 
            cisla.Where(x => x < limit).Average();
        
    }
}
