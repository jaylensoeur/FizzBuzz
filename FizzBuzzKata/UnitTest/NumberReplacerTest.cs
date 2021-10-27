using System.Collections.Generic;
using FizzBuzzKataConsole;
using Xunit;

namespace FizzBuzzKata
{
    public class NumberReplacerTest
    {
        [Fact]
        public void Replace_numbers_multiples_by_3_With_Fizz()
        {
            List<int> numbersMultipleOf3 = new List<int>
            {
                3, 6, 9
            };
            
            // action
            NumberReplacer numberReplacer = new NumberReplacer(numbersMultipleOf3);
            List<string> actual = numberReplacer.ReplaceMultipleOf(3, "Fizz");

            // assert
            Assert.Equal("Fizz", actual[0]);
            Assert.Equal("Fizz", actual[1]);
            Assert.Equal("Fizz", actual[2]);
        }
        
        [Fact]
        public void Replace_numbers_multiples_by_5_With_Buzz()
        {
            List<int> numbersMultipleOf3 = new List<int>
            {
                5, 10,15
            };
            
            // action
            NumberReplacer numberReplacer = new NumberReplacer(numbersMultipleOf3);
            List<string> actual = numberReplacer.ReplaceMultipleOf(5, "Buzz");

            // assert
            Assert.Equal("Buzz", actual[0]);
            Assert.Equal("Buzz", actual[1]);
            Assert.Equal("Buzz", actual[2]);
        }
        
        [Fact]
        public void Replace_numbers_multiples_of_3_and_5_With_FizzBuzz()
        {
            List<int> numbersMultipleOf3And5 = new List<int>
            {
                15,30,45,60
            };
            
            // action
            NumberReplacer numberReplacer = new NumberReplacer(numbersMultipleOf3And5);
            int[] numbers = { 3, 5};
            List<string> actual = numberReplacer.ReplaceMultipleOf(numbers, "FizzBuzz");

            // assert
            Assert.Equal("FizzBuzz", actual[0]);
            Assert.Equal("FizzBuzz", actual[1]);
            Assert.Equal("FizzBuzz", actual[2]);
            Assert.Equal("FizzBuzz", actual[3]);
        }
        
        [Fact]
        public void Does_not_replace_numbers_that_are_not_multiples_of_3_and_5_with_FizzBuzz()
        {
            List<int> numbersMultipleOf3And5 = new List<int>
            {
                14,16,17,18,19,20
            };
            
            // action
            NumberReplacer numberReplacer = new NumberReplacer(numbersMultipleOf3And5);
            int[] numbers = { 3, 5};
            List<string> actual = numberReplacer.ReplaceMultipleOf(numbers, "FizzBuzz");

            // assert
            Assert.Equal("14", actual[0]);
            Assert.Equal("16", actual[1]);
            Assert.Equal("17", actual[2]);
            Assert.Equal("18", actual[3]);
            Assert.Equal("19", actual[4]);
            Assert.Equal("20", actual[5]);
        }
        
    }
}