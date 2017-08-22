using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rajasekhar_Genesys
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int>();
                string[] input = Console.ReadLine().Split(' ');
                Console.WriteLine(input.Length);
                foreach (string  n in input)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
                numbers = input.Where(x=>!string.IsNullOrWhiteSpace(x) ).Select(x => int.Parse(x.Trim())).ToList();


                List<int> Output = new List<int>();

                bool skip = false;
                foreach(int n in numbers)
                {
                    int final = n;
                    if (!skip){
                        if (n == 0)
                        {
                            final = n;
                            skip = true;
                        }
                        else if (n < 0)
                            final = -1 * n;
                        else if (n < 7 && n > 4)
                            final = n + 4;
                        else if (n>6 && (n / 6) % 2 == 0)
                            final = n / 2;
                        else if (n % 2 == 1)
                            final = n - 1;
                    }
                    Output.Add(final);
                    
                }

                foreach(int n in Output)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
            

            
            catch(FormatException)
            {
                Console.WriteLine("Please enter valid array of numbers");
            }
            Exit();

        }

        private static void Exit()
        {
            Console.WriteLine("Enter any key to exit");
            Console.ReadKey();
        }
    }
}
