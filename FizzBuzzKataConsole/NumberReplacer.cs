using System.Collections.Generic;

namespace FizzBuzzKataConsole
{
    public class NumberReplacer
    {
        private readonly List<int> _numbers;
         
        public NumberReplacer(List<int> numbers)
        {
            _numbers = numbers;
        }

        public List<string> ReplaceMultipleOf(int multiples, string replaceWith)
        {
            List<string> replacedString = new List<string>();
            
            for (int i = 0; i < _numbers.Count; i++)
            {
                if (_numbers[i] % multiples == 0)
                {
                    replacedString.Add(replaceWith);
                }
                else
                {
                    replacedString.Add(_numbers[i].ToString());
                }
            }

            return replacedString;
        }

        public List<string> ReplaceMultipleOf(int[] multiples, string replaceWith)
        {
            int result = multiples[0] * multiples[1];
            return this.ReplaceMultipleOf(result, replaceWith);
        }
    }
}