using System.Collections.Generic;

namespace FizzBuzzKataConsole
{
    public class FizzBuzz
    {
        private readonly NumberReplacer _numberReplacer;
        
        public FizzBuzz(NumberReplacer numberReplacer)
        {
            _numberReplacer = numberReplacer;
        }
        
        public List<string> Go()
        {
            int[] multiples = {3, 5};
            
            List<string> fizz = _numberReplacer.ReplaceMultipleOf(3, "fizz");
            List<string> buzz = _numberReplacer.ReplaceMultipleOf(5, "buzz");
            List<string> fizzBuzz = _numberReplacer.ReplaceMultipleOf(multiples, "fizzbuzz");
            
        }
    }
}