using System.Diagnostics;
using System.Text;
using System.Linq;

namespace _01_OOP_120_Ref_a_val
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string hello = "Hello, World!";
            //Prodluz(hello);
            //Console.WriteLine(hello);

            //int count = 400000;
            //string str = "";
            //StringBuilder sb = new StringBuilder();

            //Stopwatch sw = new Stopwatch();
            //sw.Start();

            //for (int i = 0; i < count; i++)
            //{
            //    //str += 'A';
            //    sb.Append('A');
            //}

            //sw.Stop();
            ////Console.WriteLine(sw.ElapsedTicks);
            //Console.WriteLine(sw.ElapsedMilliseconds);
            //Console.WriteLine(sb.ToString().Length);


            int[] pole = [7, 2, 3, 4, 5, 6];
            int[] poleCopy = [.. pole];

            int[] pole2 = pole.OrderBy(x => x).ToArray(); //udělám kopii

            Array.Sort(pole2);
            Console.WriteLine(string.Join(',', pole));
            
        }

        static void Prodluz(string s)
        {
            s += 'A';
        }
    }



}
