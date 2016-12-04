using System;
using System.ServiceModel;

namespace IMDBHost
{
    class Program
    {
        static void Main()
        {
            using (var host = new ServiceHost(typeof(IMDBWCF.Service)))
            {
                host.Open();

                Console.WriteLine("Host stated...");
                Console.ReadLine();
            }
        }
    }
}
