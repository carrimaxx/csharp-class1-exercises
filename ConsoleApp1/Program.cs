using System;

namespace AreaofRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length of the rectangle?");
            string input1 = Console.ReadLine();
            float length = float.Parse(input1);

            Console.WriteLine("What is the width of the rectangle?");
            string input2 = Console.ReadLine();
            float width = float.Parse(input2);

            Console.WriteLine("The area of the rectangle is " + width * length + '.');
        }
    }
}
