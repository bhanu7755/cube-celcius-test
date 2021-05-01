using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemperatureConversion.API.Model;

namespace TemperatureConversion.API.TemperatureFactory
{
    public class CelciusTemperature : ITempConvert
    {       
        public float GetConvertedVal(string to, float value)
        {
            float result = 0;
            if(to == Constants.FAHRENHEIT)
            {
                result = value * 18f / 10f + 32f;
            }
            else if (to == Constants.KELVIN)
            {
                result = value + 273f;
            }

            return result;
        }
    }
}
