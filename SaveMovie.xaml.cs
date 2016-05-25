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
    /// Interaction logic for SaveMovie.xaml
    /// </summary>
    public partial class SaveMovie : Window
    {
        public string ResultadoNombreBusqueda = "";
        public SaveMovie()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ResultadoNombreBusqueda = textBox.Text;
            this.Close();
        }
    }
}
