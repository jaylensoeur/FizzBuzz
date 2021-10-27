using System.Collections.Generic;
using FizzBuzzKataConsole;
using Xunit;

namespace FizzBuzzKata
{
    public class NumberGeneratorTest
    {
        [Fact]
        public void Will_Generate_Numbers_1_to_100()
        {
            NumberGenerator numberGenerator = new NumberGenerator();
            List<int> numbers = numberGenerator.GenerateInOrderFrom1To100();
            
            Assert.Equal(100, numbers.Count);
            Assert.Equal(1, numbers[0]);
            Assert.Equal(100, numbers[99]);
        }
    }
}