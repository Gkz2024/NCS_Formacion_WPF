using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace NCS_Formacion_WPF
{
    public class Resultado_Model : ObservableObject
    {
        private ObservableCollection<Pelicula_Model> search;

        public ObservableCollection<Pelicula_Model> Search
        {
            get { return search; }
            set { search = value; }
        }

    }
}
