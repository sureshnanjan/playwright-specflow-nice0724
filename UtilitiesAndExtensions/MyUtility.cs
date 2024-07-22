using System.Runtime.CompilerServices;


namespace UtilitiesAndExtensions
{
    public static class MyUtility
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static void SayHello(this string str, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Hello");
            }
        }

    }
}
