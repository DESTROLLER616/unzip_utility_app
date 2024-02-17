using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unzip_utility_app.attributes;

namespace unzip_utility_app.enums
{
    public enum WatcherState
    {
        [Description("Cargando descompresor \n de archivos")]
        Default,

        [Description("Descrompresor activo, manten esta ventana abierta")]
        Active,

        [Description("Error en la aplicacion, verifique la aplicacion")]
        Error
    }
}
