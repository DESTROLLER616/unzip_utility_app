using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unzip_utility_app.attributes
{
    sealed class DescriptionAttribute : Attribute
    {
        public string Description { get; }

        public DescriptionAttribute(string descripcion)
        {
            Description = descripcion;
        }
    }
}
