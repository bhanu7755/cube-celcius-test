using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemperatureConversion.API.Model;

namespace TemperatureConversion.API.Services
{
    public interface ITemperatureConvertor
    {
        Response GetTemperature(string from, string to, float value);
    }
}
