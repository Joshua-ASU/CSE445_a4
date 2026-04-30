using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelciousFahrenheitConverter
{
    public class TempConverter
    {
        /// <summary>
        /// Converts celsius to fahrenheit.
        /// </summary>
        /// <param name="c">Provided celsius value.</param>
        /// <returns>Converted fahrenheit value.</returns>
        public static double CtoF(double c)
        {
            double f = (c * 1.8) + 32;
            return f;
        }

        /// <summary>
        /// Converts fahrenheit to celsius.
        /// </summary>
        /// <param name="f">Provided fahrenheit value.</param>
        /// <returns>Converted celsius value.</returns>
        public static double FtoC(double f)
        {
            double c = (f - 32) / 1.8;
            return c;
        }
    }
}
