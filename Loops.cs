using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ita_chsharp_training
{
   
    public class Loops
    {
        string results = " ";
        public string GetTheValueFromLoop(int numbers)
         {
             string resuls = string.Empty;

            while (numbers < 20)
            {
                if (numbers % 5 == 0 && numbers % 3 == 0)
                {
                    return "FizzBuzz";
                }

                else if (numbers % 5 == 0)
                {
                    return "Buzz";
                }
                else if (numbers % 3 == 0)
                {
                    return "Fizz";
                }
                else
                {
                    return numbers.ToString();
                }

            }
            return results;
             
                  
          }
        
      }
}
