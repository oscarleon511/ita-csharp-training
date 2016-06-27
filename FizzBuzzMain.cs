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
        //string _result = " ";
        public string DoTheFizzBuzz(int number)
        {

         
                
                if (number % 3 == 0 && number % 5== 0)
                {
                    return "FizzBuzz";

                }  
                    
                    if(number % 3 == 0)
                {
                     return "Fizz";
                }
                   
                else if (number % 5 == 0)
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

