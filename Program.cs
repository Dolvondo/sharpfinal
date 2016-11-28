using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
          
        }
        public int myInt = 10;

        public static void MyFunction () {
                Console.WriteLine("Run Function");
        }

        public static int IntFunction (int _peram) {
            return _peram + myInt;
        }
    }

}
