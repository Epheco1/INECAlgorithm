using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace INECAlgorithm
{
        internal class InecSolution
        {
            public void DetectMultipleRegistration(List<string> names, IEnumerable<string> distinctList)
            {
                foreach (var voter in distinctList)
                {
                    int occurence = names.Count(n => n == voter);
                    if (occurence > 1)
                    {
                        Console.WriteLine(voter + " registered " + occurence + " times\n");
                    }
                }
            }

            //function to help prevent multiple registration
            public void PreventMultipleRegistration(List<string> names)
            {
                try
                {
                    Console.WriteLine("Enter your name: ");
                    string newVoter = Console.ReadLine().ToLower();
                    if (names.Contains(newVoter))
                    {
                        Console.WriteLine("This voter already exists");
                    }
                    else
                    {
                        names.Add(newVoter);
                        Console.WriteLine("Your registration has been approved\n");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Something went wrong.");
                }


            }
        }
}
