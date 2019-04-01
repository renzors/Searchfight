using Searchfight.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Searchfight
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 2)
            {
                ISearchServiceFactory factory = new SearchServiceConfiguration();
                var services = factory.GetAvailableServices();

                foreach(var arg in args)
                {
                    Console.Write($"{arg}: ");

                    foreach (var service in services)
                        Console.Write($"{service.GetResults(arg)} ");
                    
                    Console.Write("\n");
                }

                foreach (var service in services)
                    Console.WriteLine(service.WinnerToString());

                Console.WriteLine($"Total winner: {factory.GetOverAllWinner(services)}");

                Console.ReadKey();
            }

            Console.WriteLine("Enter at least 2 words.");
        }
    }
}
