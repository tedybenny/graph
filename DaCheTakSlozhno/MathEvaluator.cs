using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaCheTakSlozhno
{
    public class MathEvaluator
    {
        public double Evaluate(String input,int a)
        {
            if(a < 0)
            {
                input = input.Replace("-x", Convert.ToString(a));
            }
            input = input.Replace("x", Convert.ToString(a));
            Expression e = new Expression(input);
            return e.calculate();
        }
    }
}
