namespace AlgorithmsBag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Node<int> numberNode1 = new Node<int>(1);
            //Node<int> numberNode2 = new Node<int>(2);
            //Node<int> numberNode3 = new Node<int>(3);

            //numberNode1.next = numberNode2;
            //numberNode2.next = numberNode3;

            //Console.WriteLine(numberNode1.value);

            //Node<int> next = numberNode1;
            //while (next != null)
            //{
            //    Console.WriteLine(next.value);
            //    next = next.next;
            //}
            Bag<int> bag = new Bag<int>();
            bag.Add(1);
            bag.Add(2);
            bag.Add(3);
            bag.Add(4);
            bag.Add(5);

            // Display the bag elements in different colors
            DisplayBagElements(bag, ConsoleColor.Cyan);
            DisplayBagElements(bag, ConsoleColor.Magenta);
            DisplayBagElements(bag, ConsoleColor.Yellow);
            DisplayBagElements(bag, ConsoleColor.Green);
            DisplayBagElements(bag, ConsoleColor.Red);
        }

        private static void DisplayBagElements(Bag<int> bag, ConsoleColor color)
        {
            Console.Clear();
            Console.ForegroundColor = color;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Randomized Bag Elements:");

            var iterator = bag.GetIterator();
            while (iterator.HasNext())
            {
                Console.Write("\n    ");
                Console.Write(iterator.Next());
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
