using System;
using System.Collections.Generic;
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

namespace NCS_Formacion_WPF
{
    /// <summary>
    /// Lógica de interacción para DetallePelicula.xaml
    /// </summary>
    public partial class DetallePelicula : Window
    {
        public Pelicula pelicula;

        public DetallePelicula()
        {
            InitializeComponent();

        }

        private void Window_Activated(object sender, EventArgs e)
        {
            this.DataContext = pelicula;
        }
    }
}
