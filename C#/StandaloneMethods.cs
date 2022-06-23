using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Company.ClassesAndInterface;

namespace Company
{
    internal class StandaloneMethods
    {
        public static List<Node> GenerateRandomDerivedNodes(int n)
        {
            int minRangeX = -50;
            int maxRangeX = 200;
            int minRangeY = -50;
            int maxRangeY = 200;

            int NameLength = 10;

            // Instantiate random number generator using system-supplied value as seed.
            var rand = new Random();

            var ListOfRandomNodes = new List<Node>();

            string RandomUppercaseString(int length)
            {
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                var stringChars = new char[length];
                var random = new Random();

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                return new String(stringChars);
            }

            int RandomNumber(int minRange, int maxRange)
            {
                return rand.Next(minRange, maxRange);
            }

            for (int i = 0; i < n; i++)
            {
                var NewRandomNode = new DerivedNode(RandomUppercaseString(NameLength), RandomNumber(minRangeX, maxRangeX), RandomNumber(minRangeY, maxRangeY));
                ListOfRandomNodes.Add(NewRandomNode);
            }

            return ListOfRandomNodes;

        }

        public static List<Node> ProcessNodes(List<Node> listA, List<Node> listB)
        {
            // combine two lists
            var combinedNodes = listA.Concat(listB);

            // filter : X or Y < 0, X > 150, Y > 100
            // Order by X, if shared X value order by Y
            var filteredCombinedNodes = combinedNodes.Where(node => 0 < node.X && node.X < 150 && 0 < node.Y && node.Y < 100)
                                                     .OrderBy(node => node.X).ThenBy(node => node.Y);
            //var filteredCombinedNodes = from node in combinedNodes
            //                            where 0 < node.X
            //                            && node.X < 150
            //                            && 0 < node.Y
            //                            && node.Y < 100
            //                            //orderby node.X, node.Y
            //                            select node;

            return filteredCombinedNodes.ToList();
        }


    }
}
