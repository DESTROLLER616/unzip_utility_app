using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unzip_utility_app.attributes;
using unzip_utility_app.enums;

namespace unzip_utility_app
{
    public static class WatcherDescription
    {
        public static string returnDescription(WatcherState ws)
        {
            var descripcionAttribute = (DescriptionAttribute)Attribute.GetCustomAttribute(
                typeof(WatcherState).GetField(ws.ToString()),
                typeof(DescriptionAttribute));

            string description = descripcionAttribute?.Description ?? "No hay descripcion";

            return description;
        }
    }
}
