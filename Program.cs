using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> cities = new MyDictionary<string, string>();

            cities.Add("1", "Ankara");
            cities.Add("2", "İstanbul");
            cities.Add("3", "İzmir");

            cities.Listing();
            Console.ReadLine();
        }
    }
}
