using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemperatureConversion.API.Model
{
    public class BaseRequest
    {        
        public string From { get; set; }
        
        public string To { get; set; }
    }
}
