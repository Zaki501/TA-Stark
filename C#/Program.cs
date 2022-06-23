using static Company.ClassesAndInterface;
using static Company.StandaloneMethods;

namespace Company
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Euclidean distance
            var testNode = new DerivedNode("hello", 1, 1);
            Console.WriteLine();
            Console.WriteLine(testNode.ToString());
            Console.WriteLine();
            Console.WriteLine(testNode.GetDistance(1000, 1000));
            Console.WriteLine();

            // ListA
            var list_one = GenerateRandomDerivedNodes(100);
            list_one.ForEach(x => Console.WriteLine(x.ToString()));
            Console.WriteLine("");

            // ListB
            var list_two = GenerateRandomDerivedNodes(100);
            list_two.ForEach(x => Console.WriteLine(x.ToString()));
            Console.WriteLine("");

            // Combined and filtered lists
            var filteredAndCombinedNodeList = ProcessNodes(list_one, list_two);
            filteredAndCombinedNodeList.ForEach(x => Console.WriteLine(x.ToString()));

        }

    }
}
