using System;

namespace NameCounting
{
    class Program
    {
        //static string[] names = new string[100];
        //static int[] counts = new int[100];
        static PersonCounter[] personCounters = new PersonCounter[100];
        static int count = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Skriv et navn: ");
                var name = Console.ReadLine();
                var personCounter = FindOrCreateName(name);
                personCounter.IncreaseCount();
                ShowCounts();
            }
        }

        private static void ShowCounts()
        {
            for (var i = 0; i < count; i++)
            {
                personCounters[i].Show();
            }
        }

        private static PersonCounter FindOrCreateName(string name)
        {
            var i = 0;
            for (; i < count; i++)
            {
                if (personCounters[i].Name == name) return personCounters[i];
            }
            // Name is not in list
            personCounters[i] = new PersonCounter {Name = name};
            count++;
            return personCounters[i];
        }
    }
}
