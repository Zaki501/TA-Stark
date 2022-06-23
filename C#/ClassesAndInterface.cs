using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    internal class ClassesAndInterface
    {

public class EmployeeListNotFoundException : Exception
{
    public EmployeeListNotFoundException()
    {
    }

    public EmployeeListNotFoundException(string message)
        : base(message)
    {
    }

    public EmployeeListNotFoundException(string message, Exception inner)
        : base(message, inner)
    {
    }
}

        public interface IDistance
        {
            double GetDistance(int x, int y);
        }


        public abstract class Node
        {
            public int X { get; set; }
            public int Y { get; set; }
        }



        public class DerivedNode : Node, IDistance
        {
            public string Name;
            public DerivedNode(string _name, int x, int y)
            {
                Name = _name;
                X = x;
                Y = y;
            }
            public override string ToString()
            {
                return "Name: " + Name + ", X: " + X + ", Y: " + Y;
            }
            public double GetDistance(int x, int y)
            {
                // distance between DerivedNodes (x, y), and parameters passed in
                int dX = X - x;
                int dY = Y - y;
                double distance = Math.Sqrt(dX * dX + dY * dY);

                if (distance > 200)
                {
                    throw new Exception(
                        "OutofRange");
                }
                return distance;
            }
        }



    }
}
