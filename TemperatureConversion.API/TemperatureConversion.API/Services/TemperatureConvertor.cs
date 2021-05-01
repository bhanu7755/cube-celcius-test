using System;
using TemperatureConversion.API.Extensions;
using TemperatureConversion.API.Exceptions;
using TemperatureConversion.API.Model;
using TemperatureConversion.API.TemperatureFactory;

namespace TemperatureConversion.API.Services
{
    public class TemperatureConvertor : ITemperatureConvertor
    {
      
        public Response GetTemperature(string from, string to, float value)
        {
            try
            {
                ITempConvert tempConvert;
                float result;
                Response response;

                if (!from.ContainsAnyOf(Constants.CELCIUS, Constants.FAHRENHEIT, Constants.KELVIN))
                {
                    throw new InvalidInputException("Invalid from tempature conversion found");
                }

                if (!to.ContainsAnyOf(Constants.CELCIUS, Constants.FAHRENHEIT, Constants.KELVIN))
                {
                    throw new InvalidInputException("Invalid to tempature conversion found");
                }

                switch (from.ToLower())
                {
                    case "celcius":
                        tempConvert = new CelciusTemperature();
                        result = tempConvert.GetConvertedVal(to, value);
                        response = new Response()
                        {
                            From = from,
                            To = to,
                            Result = result
                        };
                        break;
                    case "fahrenheit":
                        tempConvert = new FahrenheitTemperature();
                        result = tempConvert.GetConvertedVal(to, value);
                        response = new Response()
                        {
                            From = from,
                            To = to,
                            Result = result
                        };
                        break;
                    case "kelvin":
                        tempConvert = new KelvinTempature();
                        result = tempConvert.GetConvertedVal(to, value);
                        response = new Response()
                        {
                            From = from,
                            To = to,
                            Result = result
                        };
                        break;
                    default:
                        response = new Response();
                        break;
                }
                return response;
            }
            catch(Exception ex)
            {
                throw ex;
            }       
           
        }
    }
}
