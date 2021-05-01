using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemperatureConversion.API.TemperatureFactory
{
    public interface ITempConvert
    {
        float GetConvertedVal(string to, float value);
    }
}
