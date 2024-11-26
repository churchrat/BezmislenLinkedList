namespace BezmislenLinkedList
{
    internal class Program
    {
        static void Main()
        {
            LinkedList<int> mainList = new LinkedList<int>();
            LinkedList<int> even = new LinkedList<int>();
            LinkedList<int> odd = new LinkedList<int>();
            Input(mainList);
            ListPodqlba(mainList, even, odd);
            Console.Write("All numbers: ");
            Print(mainList);
            Console.Write("Even numbers: ");
            Print(even);
            Console.Write("Odd numbers: ");
            Print(odd);           
        }
        static void Input(LinkedList<int> list)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.Write($"Enter number {i}: ");
                int number = int.Parse(Console.ReadLine());
                list.AddLast(number);
            }
        }
        static void ListPodqlba(LinkedList<int> list, LinkedList<int> even, LinkedList<int> odd)
        {
            foreach (int item in list)
            {
                if (item % 2 == 0)
                {
                    even.AddLast(item);
                }
                else
                {
                    odd.AddLast(item);
                }
            }
        }
        static void Print(LinkedList<int> list)
        {
            Console.WriteLine(string.Join(", ", list));        
        }
    }
}

