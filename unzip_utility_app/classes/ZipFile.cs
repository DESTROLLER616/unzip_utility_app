using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using unzip_utility_app.interfaces;

namespace unzip_utility_app.classes
{
    public class ZipFile : IUncompressStrategy
    {
        private string pathRoute;
        private string destinationRoute;
        private string nameZipFile;

        public ZipFile(string _pathRoute, string _destinationRoute, string _nameZipFile)
        {
            this.pathRoute = _pathRoute;
            this.destinationRoute = _destinationRoute;
            this.nameZipFile = _nameZipFile;
        }

        public void uncompress()
        {
            try
            {
                System.IO.Compression.ZipFile.ExtractToDirectory(pathRoute, Path.Combine(destinationRoute, nameZipFile));

                File.Delete(pathRoute);

                MessageBox.Show("Archivo descomprimido");
            } catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
