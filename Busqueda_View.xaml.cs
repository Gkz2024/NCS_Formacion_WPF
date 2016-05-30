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
    /// Interaction logic for Busqueda_View.xaml
    /// </summary>
    public partial class Busqueda_View : Window
    {
        public Busqueda_View()
        {
            InitializeComponent();
            MainWindow app = new MainWindow();
            Busqueda_ModelView viewModel = new Busqueda_ModelView();
            app.DataContext = viewModel;
            app.Show();
        }

        private void InitializeComponent()
        {
           
        }
    }
}
