using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLNP.Math
{
    public static class DLNPMathHelper
    {

        /// <summary>
        /// Calculates the sigmoid function for a given value
        /// </summary>
        /// <param name="x"></param>
        /// <returns>Value between 0 and 1 depending on the input</returns>
        public static double Sigmoid(double x)
        {
            return 1 / (1 + System.Math.Exp(x));
        }
    }
}
