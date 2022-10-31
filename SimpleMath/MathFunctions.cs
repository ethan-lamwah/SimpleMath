using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMath
{
    public class MathFunctions
    {
        public int Add(int num1, int num2) => num1 + num2;
        public int Subtract(int num1, int num2) => num1 - num2;
        public int Divide(int num1, int num2) => num1 / num2;
        public int Multiply(int num1, int num2) => num1 * num2;

        public int Modular(int num1, int num2) => num1 % num2;
    }
}
