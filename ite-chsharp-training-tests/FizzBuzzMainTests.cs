using System;
using ita_chsharp_training;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ite_chsharp_training_tests
{
    [TestClass]
    public class FizzBuzzMainTests
    {
        //Rule#1: If the number is evenly divisible by 3, return Fizz
        //Rule#2: If it is evebly divisible by 5 return Buzz
        //Rule#3: If the numbers are evenly divisible by 3 abd 5, return FizzBuzz
        //Rule#4: If it does not match any of the other rules just return a number
      [TestMethod]
        public void When_The_Number_Is_One()
        {
         //arrange
            FizzBuzzMain program = new FizzBuzzMain();
         //act
            string _result = program.DoTheFizzBuzz(1);
         //Assert
            Assert.AreEqual("1",_result);
            
        }
      [TestMethod]
      public void When_The_Number_Is_Two()
      {
          //arrange
          FizzBuzzMain program = new FizzBuzzMain();
          //act
          string _result = program.DoTheFizzBuzz(2);
          //Assert
          Assert.AreEqual("2", _result);

      }
      [TestMethod]
      public void When_The_Number_Is_Three()
      {
          //arrange
          FizzBuzzMain program = new FizzBuzzMain();
          //act
          string _result = program.DoTheFizzBuzz(3);
          //Assert
          Assert.AreEqual("Fizz", _result);

      }
      [TestMethod]
      public void When_The_Number_Is_five()
      {
          //arrange
          FizzBuzzMain program = new FizzBuzzMain();
          //act
          string _result = program.DoTheFizzBuzz(5);
          //Assert
          Assert.AreEqual("Buzz", _result);

      }
      [TestMethod]
      public void When_The_Number_Is_Three_And_Five()
      {
          //arrange
          FizzBuzzMain program = new FizzBuzzMain();
          //act
          string _result = program.DoTheFizzBuzz(15);
          //Assert
          Assert.AreEqual("FizzBuzz", _result);

      }
      [TestMethod]
      public void When_The_Number_Is_AnyNumber()
      {
          //arrange
          FizzBuzzMain program = new FizzBuzzMain();
          //act
          string _result = program.DoTheFizzBuzz(13);
          //Assert
          Assert.AreEqual("13", _result);

      }

    }

}
