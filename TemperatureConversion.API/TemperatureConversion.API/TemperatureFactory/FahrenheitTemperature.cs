using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemperatureConversion.API.Model;

namespace TemperatureConversion.API.TemperatureFactory
{
    public class FahrenheitTemperature : ITempConvert
    {
        public float GetConvertedVal(string to, float value)
        {
            float result = 0;
            if (to == Constants.CELCIUS)
            {
                result = (value - 32) * (5.0f / 9.0f);
            }
            else if (to == Constants.KELVIN)
            {
                result = 273.5f + ((value - 32.0f) * (5.0f / 9.0f)); ;
            }

            return result;
        }
    }
}
