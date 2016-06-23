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
        public string DoTheFizzBuzz(int number)
        {
            
            string _result = string.Empty;
            

                if (number % 5 == 0 && number % 3 == 0)
                {
                    return "FizzBuzz";
                }

                else if (number % 5 == 0)
                {
                    return "Buzz";
                }
                else if (number % 3 == 0)
                {
                    return "Fizz";
                }
                else
                {
                    
                    string formatedResult = FormatNumberForReturn(number);
                    return formatedResult;
                }  
            
            
        }
          public string FormatNumberForReturn(int number)
        {
            return number.ToString();
        }
    }
}
