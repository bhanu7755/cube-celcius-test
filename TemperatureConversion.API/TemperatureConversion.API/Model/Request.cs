using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemperatureConversion.API.Model
{
    [BindProperties]
    public class Request : BaseRequest
    {
        public float Value { get; set; }
    }
}
