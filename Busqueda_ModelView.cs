using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NCS_Formacion_WPF
{
    class Busqueda_ModelView : ObservableObject
    {
        private Busqueda_Model _busquedaActual;
        private ICommand _buscarPelicula;

        public Busqueda_Model BusquedaActual
        {
            get { return _busquedaActual; }
            set
            {
                if (value != _busquedaActual)
                {
                    _busquedaActual = value;
                    OnPropertyChanged("BusquedaActual");
                }
            }
        }

        public ICommand BuscarPelicula
        {
            get
            {
                if (_buscarPelicula == null)
                {
                    _buscarPelicula = new RelayCommand(
                        param => GetPeliculas(),
                        param => true
                    );
                }
                return _buscarPelicula;
            }
        }

        private void GetPeliculas()
        {
            
            Busqueda_Model busqueda= new Busqueda_Model();

            string ret = GetJSon();
            Pelicula_Model Pelicula = new Pelicula_Model();
            //Pelicula.Search
            List<Pelicula_Model> peliculas = JsonConvert.DeserializeObject<List<Pelicula_Model>>(ret);
            

        }

        private string GetJSon()
        {
            string ret = string.Empty;
            string url = this.GetURL();
            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            HttpWebResponse resp = (HttpWebResponse)request.GetResponse();
            Stream resStream = resp.GetResponseStream();
            StreamReader reader = new StreamReader(resStream);
            ret = reader.ReadToEnd();

            return ret;
        }

        public string GetURL()
        {
            string peliculas = string.Empty;
            string url = "http://www.omdbapi.com/?s={0}&y={1}&type={2}&plot=short&r=json";

            return string.Format(url, BusquedaActual.Titulo, BusquedaActual.Ano, BusquedaActual.Genero);
        }

    }
}