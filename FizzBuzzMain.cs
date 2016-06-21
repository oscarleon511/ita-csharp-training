using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ita_chsharp_training
{
    public class FizzBuzzMain
    {
        private int _fizz = 3;
        private int _buzz = 5;
        public int Iterations = 100;
        public int LastIteration;

        //This is parameterless constructor
        public FizzBuzzMain()
        {
           

        }

        //This is the overloaded constructor
        public FizzBuzzMain(int fizz, int buzz, int iterations)
        {
            _fizz = fizz;
            _buzz = buzz;
            Iterations = iterations;
        }

        public string ExecuteFizzBuzz()
        {
            var returnValue = "";

            for (var i = 0; i < Iterations; i++)
            {
                if (i%_fizz == 0 && i%_buzz == 0)
                {
                    returnValue = String.Format("{0}{1}", returnValue, "FizzBuzz");
                }
                else if (i%_buzz == 0)
                {
                    returnValue = String.Format("{0}{1}", returnValue, "Buzz");
                }
                else if (i%_fizz == 0)
                {
                    returnValue = String.Format("{0}{1}", returnValue, "Buzz");
                }
                else
                {
                    returnValue = String.Format("{0}{1}", returnValue, i);                    
                }
            }

            return returnValue;
        }
    }
}
