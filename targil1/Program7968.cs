using System;

namespace targil0
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Welcome7968();
            Welcome2703();
            Console.ReadKey();
        }

        static partial void Welcome2703();
        private static void Welcome7968()
        {
            Console.WriteLine("Enter your name: ");
            string user = Console.ReadLine();
            Console.WriteLine(user+ ", welcome to my first console application");
        }
    }
}
