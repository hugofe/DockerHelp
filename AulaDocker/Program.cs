using System;
using System.Threading;

namespace AulaDocker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            while(true)
            {
                Console.WriteLine("Esperando conexão....");
                Thread.Sleep(10000);
            }
        }
    }
}
