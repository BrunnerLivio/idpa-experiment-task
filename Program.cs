using System;

namespace idpa_experiment_task
{
    class FizzBuzz
    {
        /// <summary>
        /// Gibt die Zahlen vo 1 bis 100 aus. 
        /// Allerdings, bei jeder Zahl, die durch 5 teilbar ist, wird "Fizz" ausgegeben und 
        /// bei jeder Zahl, die durch 7 teilbar ist, wird "Buzz" ausgegeben. 
        /// Wenn die Zahl sowohl durch 7 als auch durch 5 teilbar ist, wird "FizzBuzz" ausgegeben.
        /// </summary>
        /// <example>
        /// 1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 [...] 98 Fizz Buzz
        /// </example>
        public void Print()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizz = new FizzBuzz();
            fizz.Print();
        }
    }
}
