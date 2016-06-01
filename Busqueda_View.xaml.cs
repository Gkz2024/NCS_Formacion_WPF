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
            
            Busqueda_ModelView viewModel = new Busqueda_ModelView();
            Busqueda_Model Busqueda_Actual = new Busqueda_Model();
            Busqueda_Actual.Titulo = "die";
            viewModel.BusquedaActual = Busqueda_Actual;
            this.DataContext = viewModel;
            
            this.Show();
    
           
        }

    
    }
}
