using System.Collections;

namespace _04_OOP_3_70_Salesmen
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "smalltree.json";
            //string filename = "largetree.json";
            Salesman boss = Salesman.DeserializeTree(File.ReadAllText(filename));

            DisplaySalesmenTree(boss);
            Console.WriteLine("------");

            Salesman jones = GetSalesmanStack(boss, "Jones")[0];

            Console.WriteLine( GetTotalSalesQueue(boss));
            Console.WriteLine(GetTotalSalesQueue(jones));

            Console.WriteLine("------");
            Console.WriteLine(GetTotalSalesRecursive(boss));
            Console.WriteLine(GetTotalSalesRecursive(jones));

            //FindSalesmanRecursive(boss, "Brown");
            //Console.WriteLine();
            //FindSalesmanStack(boss, "Brown");
            //Console.WriteLine();
            //FindSalesmanQueue(boss, "Brown");

        }
        static void DisplaySalesmenTree(Salesman node, string indent = "")
        {
            Console.WriteLine($"{indent}{node.Name} {node.Surname} - Sales: {node.Sales}");

            foreach (var subordinate in node.Subordinates)
            {
                DisplaySalesmenTree(subordinate, indent + "    ");
            }
        }

        
        static void FindSalesmanRecursive(Salesman parentNode, string surname)
        {
            if (parentNode.Surname == surname)
                Console.WriteLine($"{parentNode.Name} {parentNode.Surname} - Sales: {parentNode.Sales}");

            foreach (var subordinate in parentNode.Subordinates)
            {
                FindSalesmanRecursive(subordinate, surname);
            }
        }

        static void FindSalesmanStack(Salesman parentNode, string surname)
        {
            Stack<Salesman> toBeVisited = new Stack<Salesman>();
            toBeVisited.Push(parentNode);

            while (toBeVisited.Count > 0)
            {
                Salesman current = toBeVisited.Pop();
                if (current.Surname == surname)
                    Console.WriteLine($"{current.Name} {current.Surname} - Sales: {current.Sales}");

                foreach (Salesman subordinate in current.Subordinates)
                {
                    toBeVisited.Push(subordinate);
                }
            }
        }

        static void FindSalesmanQueue(Salesman parentNode, string surname)
        {
            Queue<Salesman> toBeVisited = new Queue<Salesman>();
            toBeVisited.Enqueue(parentNode);

            while (toBeVisited.Count > 0)
            {
                Salesman current = toBeVisited.Dequeue();
                if (current.Surname == surname)
                    Console.WriteLine($"{current.Name} {current.Surname} - Sales: {current.Sales}");

                foreach (Salesman subordinate in current.Subordinates)
                {
                    toBeVisited.Enqueue(subordinate);
                }
            }
        }

        static int GetTotalSalesQueue(Salesman parentNode)
        {
            int total = 0;

            Queue<Salesman> toBeVisited = new Queue<Salesman>();
            toBeVisited.Enqueue(parentNode);

            while (toBeVisited.Count > 0)
            {
                Salesman current = toBeVisited.Dequeue();
                total += current.Sales;

                foreach (Salesman subordinate in current.Subordinates)
                {
                    toBeVisited.Enqueue(subordinate);
                }
            }

            return total;
        }

        static int GetTotalSalesRecursive(Salesman parentNode)
        {
            int total = parentNode.Sales;

            foreach (var subordinate in parentNode.Subordinates)
            {
                total += GetTotalSalesRecursive(subordinate);
            }

            return total;
        }

        static Salesman[] GetSalesmanStack(Salesman parentNode, string surname)
        {
            List<Salesman> found = new List<Salesman>();
            Stack<Salesman> toBeVisited = new Stack<Salesman>();
            toBeVisited.Push(parentNode);

            while (toBeVisited.Count > 0)
            {
                Salesman current = toBeVisited.Pop();
                if (current.Surname == surname)
                    found.Add(current);

                foreach (Salesman subordinate in current.Subordinates)
                {
                    toBeVisited.Push(subordinate);
                }
            }

            return found.ToArray();
        }

    }
}
