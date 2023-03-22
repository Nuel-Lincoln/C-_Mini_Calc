using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Calculator
{
    public class Operators
    {
        public float Add(dynamic a, dynamic b) {
                
                return a + b;
        
            }

        public float Multiply(dynamic a, dynamic b)
        {

            return a * b;

        }

        public float Subtract(dynamic a, dynamic b)
        {
            
                return a - b;
                

        }

        public float Divide(dynamic a, dynamic b)
            {
            
                    return a / b;
            
            }
    }
}
