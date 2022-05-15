using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using webRGE.Entities.Enum;

namespace webRGE.Services
{
    public class CommonService
    {
        public Dictionary<int, string> GetFileTypeDictionaty()
        {
            var names = typeof(TabelNames)
                             .GetFields(BindingFlags.Public | BindingFlags.Static)
                             .Select(f => f.GetCustomAttribute<DisplayAttribute>().Name);
            var values = Enum.GetValues(typeof(TabelNames)).Cast<int>();

            return names.Zip(values, (n, v) => new KeyValuePair<int, string>(v, n))
                .ToDictionary(kv => kv.Key, kv => kv.Value);
        }
    }
}
