using System;

namespace Travis
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new Service().DoSomething();

            Console.WriteLine("Hello {0}", name);
        }
    }
}
