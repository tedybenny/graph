using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaCheTakSlozhno
{

    class Model
    {
        MathEvaluator math = new MathEvaluator();
        public string Xmin
        {
            get;
            set;
        }
        public string Xmax
        {
            get;
            set;
        }
        public string userFormula
        {
            get;
            set;
        }
        public double PointY(int a)
        {
            double result = math.Evaluate(userFormula,a);
            return result;
        }

    }
}
