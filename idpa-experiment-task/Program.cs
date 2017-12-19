using System;

namespace idpa_experiment_task
{
    public class FizzBuzz
    {
        /// <summary>
        /// Gibt die Zahlen vo 1 bis 100 zurück als string. 
        /// Allerdings, bei jeder Zahl, die durch 5 teilbar ist, wird "Fizz" ausgegeben und 
        /// bei jeder Zahl, die durch 7 teilbar ist, wird "Buzz" ausgegeben. 
        /// Wenn die Zahl sowohl durch 7 als auch durch 5 teilbar ist, wird "FizzBuzz" ausgegeben.
        /// </summary>
        /// <param name="iterations">Die Anzahl Nummern es ausgeben sollte</param>
        /// <example>
        /// > FizzBuzz.Print(100);
        /// 1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 [...] 98 Fizz Buzz
        /// </example>
        public string GetFizzBuzzString(int iterations)
        {
            string fizzBuzzString = "";
            for (int i = 1; i <= iterations; i++)
            {
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;
                if (fizz && buzz)
                    fizzBuzzString += "FizzBuzz ";
                else if (fizz)
                    fizzBuzzString += "Fizz ";
                else if (buzz)
                    fizzBuzzString += "Buzz ";
                else
                    fizzBuzzString += i + " ";
            }
            return fizzBuzzString;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizz = new FizzBuzz();
            Console.WriteLine(fizz.GetFizzBuzzString(231));
        }
    }
}
