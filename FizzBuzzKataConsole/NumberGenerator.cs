using System.Collections.Generic;

namespace FizzBuzzKataConsole
{
    public class NumberGenerator
    {
        public List<int> GenerateInOrderFrom1To100()
        {
            List<int> numbers = new List<int>();
            
            for (int i = 1; i <= 100; i++)
            {
                numbers.Add(i);    
            }

            return numbers;
        }
    }
}