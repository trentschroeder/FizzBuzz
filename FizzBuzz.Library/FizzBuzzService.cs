using System;
using System.Collections.Generic;

namespace FizzBuzz.Library
{
    public class FizzBuzzService
    {
        public string Print(int number)
        {
           if (isDivisibleBy3(number) && isDivisibleBy5(number)){
               return "FizzBuzz";
           } else if (isDivisibleBy3(number)){
               return "Fizz";
           } else if (isDivisibleBy5(number)){
               return "Buzz";
           } else return number.ToString();
        }

        private bool isDivisibleBy3(int number){
            return number % 3 ==0;
        }
         private bool isDivisibleBy5(int number){
            return number % 5 ==0;
        }
    }
}