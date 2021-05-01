using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemperatureConversion.API.Model;

namespace TemperatureConversion.API.TemperatureFactory
{
    public class KelvinTempature : ITempConvert
    {
        public float GetConvertedVal(string to, float value)
        {
            float result = 0;
            if (to == Constants.CELCIUS)
            {
                result = value - 273f;
            }
            else if (to == Constants.FAHRENHEIT)
            {
                result = (1.8f * (value - 273f) + 32f);
            }

            return result;
        }
    }
}
