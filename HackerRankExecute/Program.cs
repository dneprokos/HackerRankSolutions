using HackerRankProblems.Implementations;
using System;
using System.Collections.Generic;

namespace HackerRankExecute
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting ESO servers statuses...");

            Dictionary<string, string> serverAndStatus = EsoServer.GetEsoServersStatuses();

            Console.WriteLine("\n");

            foreach (var server in serverAndStatus)
            {
                Console.WriteLine(server.Key + " is " + server.Value);
            }

            Console.ReadLine();
        }
    }
}
