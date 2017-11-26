using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FizzBuzz
{
    static class Program
    {
        #region Paramaters
        private static readonly int _speed = 5;
        private static readonly int _startIndex = 0;
        private static readonly int _endIndex = 500;
        #endregion

        private static void Main()
        {
            // Pre-conditions;
            if (_startIndex > _endIndex)
                throw new ArgumentOutOfRangeException("Start Index cannot be less than End Index");
            if (_speed <= 0)
                throw new ArgumentOutOfRangeException("Speed cannot be <= 0");

            // Play fizz-buzz
            for (var x = _startIndex; x <= _endIndex; ++x)
            {
                Console.WriteLine(PlayFixBang(x, 3, 5));

                // printout throttle
                Thread.Sleep(1000 / _speed);
            }

            Console.ReadKey(); // keep cmd open when done...
        }

        private static string PlayFixBang(int currentInxex, int fizzIndex, int buzzIndex)
        {

            // Check Fizz
            var responce = currentInxex % fizzIndex == 0 ? "Fizz " : "";

            // Check Buzz
            responce += currentInxex % buzzIndex == 0 ? "Buzz" : "";

            // If not fizz of buzz return index, else return responce
            return responce == "" ? currentInxex.ToString() : responce.Trim();
        }
    }
}