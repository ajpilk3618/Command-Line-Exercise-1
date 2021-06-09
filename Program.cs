using System;
using System.Threading;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bridge keeper: 'Stop, who would cross the Bridge of Death Must answer me these questions three, 'ere the other side he see'");
                Thread.Sleep(3000);

            Console.WriteLine("Ask me the questions bridge keeper, I'm not afraid");
                Thread.Sleep(1000);
            
            Console.WriteLine("Bridge keeper: 'What is your Name?'");
                Thread.Sleep(1000);

            var name = Console.ReadLine();

            Console.WriteLine("Bridge keeper: 'What is your Quest?'");

            var quest = Console.ReadLine();
            Console.WriteLine($"{name}: '{quest}'");
                Thread.Sleep(1000);
            
            Console.WriteLine("Bridge keeper: 'What is your favorite color?'");

            var color = Console.ReadLine();
            Console.WriteLine($"{name}: '{color}'");
                Thread.Sleep(1000);
            
            Console.WriteLine("Bridge keeper: 'Right, off you go'");
            
        }
    }
}
