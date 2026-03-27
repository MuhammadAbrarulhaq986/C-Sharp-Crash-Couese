using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Crash_Couese
{
    internal class ConditionalOperator
    {
        public void Show()
        {
            /* Conditional Operator = Used in conditional Assignment if a conditions is true/fals 
                 (Condtion) ? (Value if true) : (Value if false)    
                 (Condtion) ? x : y                        
            */

            double temp = 20;
            String message;

            //Console.WriteLine(message);
            message = (temp >= 15) ? "It's warm outside!" : "It's cold outside" ;

            Console.WriteLine((temp >= 15) ? "It's warm outside!" : "It's cold outside");

            //if (temp >= 15)
            //{
            //    message = "It's warm outside";
            //}
            //else
            //{
            //    message = "It's cold outside";
            //}
        }
    }
}
