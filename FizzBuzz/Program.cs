using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> fizzBuzz = new List<string>();
            Console.Write("Please enter the number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            List<int> userNumberList = new List<int>(Enumerable.Range(1, userNumber));
            
            // constraint 1<= n <= 10000
            if (1 <= userNumber && userNumber <= 10000)
            {
                foreach (var VARIABLE in userNumberList)
                {
                    if (VARIABLE % 3 == 0 && VARIABLE % 5 == 0)
                    {
                        fizzBuzz.Add("FizzBuzz");
                    }
                    else if (VARIABLE % 3 == 0)
                    {
                        fizzBuzz.Add("Fizz");
                    }
                    else if (VARIABLE % 5 == 0)
                    {
                        fizzBuzz.Add("Buzz");
                    }
                    else
                    {
                        fizzBuzz.Add(VARIABLE.ToString());
                    }
                }
            }
            else
            {
                Console.WriteLine("Please check the constraint.");
            }
            
            string fizzBuzzList = String.Join(", ", fizzBuzz);
            Console.WriteLine(fizzBuzzList);
            
        }
    }
}