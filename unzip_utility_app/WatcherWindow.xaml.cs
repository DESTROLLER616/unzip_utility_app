using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using unzip_utility_app.attributes;
using unzip_utility_app.classes;
using unzip_utility_app.enums;

namespace unzip_utility_app
{
    /// <summary>
    /// Lógica de interacción para WatcherWindow.xaml
    /// </summary>
    public partial class WatcherWindow : Window
    {
        static WatcherState ws = WatcherState.Default;
        static string directory = @"C:\Users\destr\OneDrive\Escritorio\programacion\test"; 
        public WatcherWindow()
        {
            InitializeComponent();
            watcherDirectory();
        }

        private void stateLabel_Loaded(object sender, RoutedEventArgs e)
        {
            string description = WatcherDescription.returnDescription(ws);

            stateLabel.Content = description;
        }

        private void watcherDirectory()
        {
            // Crear una instancia de FileSystemWatcher
            FileSystemWatcher watcher = new FileSystemWatcher(directory);

            // Configurar las notificaciones que te interesan
            watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName;

            watcher.Filter = "*.zip";

            // Manejar el evento cuando se crea un nuevo archivo
            watcher.Created += OnArchivoCreado;

            // Iniciar la vigilancia
            watcher.EnableRaisingEvents = true;

            MessageBox.Show($"Vigilando el directorio: {directory}");
        }

        private static void OnArchivoCreado(object sender, FileSystemEventArgs e)
        {
            ZipFile zf = new(e.FullPath, @"C:\Users\destr\OneDrive\Escritorio\programacion\uncompress", System.IO.Path.GetFileNameWithoutExtension(e.FullPath));
            zf.uncompress();
        }
    }
}
