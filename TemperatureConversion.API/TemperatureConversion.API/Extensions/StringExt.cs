using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemperatureConversion.API.Extensions
{
    public static class StringExt
    {
        public static bool ContainsAnyOf(this string source, params string[] strings)
        {
            return strings.Any(x => source.Contains(x));
        }
    }
}
