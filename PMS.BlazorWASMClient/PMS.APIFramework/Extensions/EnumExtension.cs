using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace PMS.BlazorWASMClient.Utility.Extensions
{
    public static class EnumExtension
    {
        public static string DisplayName(this Enum value)
        {
            string name = string.Empty;

            var attribute = value.GetType().GetField(value.ToString()).GetCustomAttributes<DisplayAttribute>(false).FirstOrDefault();

            if(attribute is null)
            {
                name = value.ToString();
            }
            else
            {
                var propValue = attribute.GetType().GetProperty("Name").GetValue(attribute, null);
                name = propValue.ToString();
            }

            return name;
        }
    }
}
