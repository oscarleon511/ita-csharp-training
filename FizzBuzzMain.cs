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

            if (number % 3 == 0)
            {
                return "Fizz";
            }
           
            else if ( number % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
        }
          
    }
}
