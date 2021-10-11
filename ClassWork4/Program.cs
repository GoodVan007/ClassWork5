using System;


namespace ClassWork4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(GetHalfString("Hello, world"));
            Console.WriteLine(GetHalfString(""));
            Console.WriteLine(GetHalfString("A B C D") +'#');
            Console.WriteLine(GetHalfString("                            ") + '#');

            Console.ReadKey();


        }

        static string GetHalfString(string fullString)
        {
            var s = fullString.Replace(" ", "");
            return s.Substring(s.Length / 2);

        }



    }
}
