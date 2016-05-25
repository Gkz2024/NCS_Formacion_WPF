using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NCS_Formacion_WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Busqueda busquedaActual;
        private List<Busqueda> ListaBusquedas = new List<Busqueda> { };
        private Busqueda busquedaTest = new Busqueda();

        public MainWindow()
        {
            InitializeComponent();
            busquedaActual = new Busqueda();
            this.DataContext = busquedaActual;
            ListaBusqueda.ItemsSource = ListaBusquedas;
            //busquedaTest.NombreBusqueda = "Prueba";
            //ListaBusquedas.Add(busquedaTest);

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string ret = GetJSon();
            resultado peliculas = JsonConvert.DeserializeObject<resultado>(ret);
            listView.ItemsSource = peliculas.Search;
        }

        private string GetJSon()
        {
            string ret = string.Empty;
            string url = busquedaActual.GetURL();


            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            HttpWebResponse resp = (HttpWebResponse)request.GetResponse();
            Stream resStream = resp.GetResponseStream();
            StreamReader reader = new StreamReader(resStream);
            ret = reader.ReadToEnd();

            return ret;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (listView.SelectedIndex > -1)
            {
                DetallePelicula dp = new DetallePelicula();
                dp.pelicula = (Pelicula)listView.SelectedItem;
                dp.Show();
             
            }


        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            SaveMovie sm = new SaveMovie();
            sm.textBox.Text = "Nombre busqueda";
            sm.Show();
            busquedaActual.NombreBusqueda = sm.ResultadoNombreBusqueda;
            ListaBusquedas.Add(busquedaActual);
        }
    }
}
