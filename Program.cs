using System;
using System.Net.NetworkInformation;

namespace Metztli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                IPInterfaceProperties properties = adapter.GetIPProperties();
                Console.WriteLine(adapter.Description + ", " + adapter.GetPhysicalAddress());
            } 
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
