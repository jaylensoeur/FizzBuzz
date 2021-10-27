using System.Collections.Generic;
using FizzBuzzKataConsole;
using Xunit;

namespace FizzBuzzKata
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Replace_3_with_fizz_5_with_buzz_and_15_with_fizzBuzz()
        {
            var numberGenerator = new NumberGenerator();
            var numberReplacer = new NumberReplacer(numberGenerator.GenerateInOrderFrom1To100());
            var fizzBuzz = new FizzBuzz(numberReplacer);
            List<string> fizzBuzzList = fizzBuzz.Go();
            
            Assert.Equal("fizz", fizzBuzzList[2]);
            Assert.Equal("buzz", fizzBuzzList[4]);
            Assert.Equal("fizzBuzz", fizzBuzzList[14]);
        }
    }
}