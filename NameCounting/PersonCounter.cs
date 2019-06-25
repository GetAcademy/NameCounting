using System;

namespace NameCounting
{
    public class PersonCounter
    {
        public string Name;
        public int Count { get; private set; }

        public void Show()
        {
            Console.WriteLine(Name + " " + Count);
        }

        public void IncreaseCount()
        {
            Count++;
        }
    }
}
