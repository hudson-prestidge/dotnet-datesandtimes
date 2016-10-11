using System;

namespace DatesAndTimes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString());
            Console.WriteLine(myValue.ToString("d"));
            Console.WriteLine(myValue.ToString("t"));



            Console.ReadLine();
        }
    }
}
