using System;
using System.Collections.Generic;
using System.Linq;

namespace INECAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> votersName = new List<string>()
            {
                "williams ibekwe",
                "john dumelo",
                "eniola savage",
                "kolawole sodiq",
                "rose afije",
                "williams ibekwe",
                "williams ibekwe",
                "eniola savage"
            };
            var distinctList = votersName.Distinct();

            InecSolution inec = new InecSolution();

            inec.DetectMultipleRegistration(votersName, distinctList);

            inec.PreventMultipleRegistration(votersName);

            foreach (var voter in distinctList)
            {
                Console.WriteLine(voter);
            }
        }
    }
}