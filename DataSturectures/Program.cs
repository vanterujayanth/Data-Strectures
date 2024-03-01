namespace DataSturectures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList lnklist = new LinkedList();
            lnklist.PrintAllNodes();
            Console.WriteLine();

            lnklist.PrintAllNodes();
            lnklist.AddAtLast(12);
            lnklist.AddAtLast("John");
            lnklist.AddAtLast("Peter");
            lnklist.AddAtLast(34);
            lnklist.PrintAllNodes();
            Console.WriteLine();

            lnklist.AddAtStart(55);
            lnklist.PrintAllNodes();
            Console.WriteLine();

            lnklist.RemoveFromStart();
            lnklist.PrintAllNodes();


            Console.ReadKey();

        }
    }
}
