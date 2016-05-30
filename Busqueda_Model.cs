using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS_Formacion_WPF
{
    class Busqueda_Model : ObservableObject
    {

        private string nombreBusqueda;
        private string m_titulo;
        private string m_ano;
        private string m_genero;

        public string NombreBusqueda
        {
            get
            {
                return nombreBusqueda;

            }

            set
            {
                nombreBusqueda = value;
            }
        }
        public string Titulo
        {
            get
            {
                return m_titulo;
            }

            set
            {
                if (m_titulo != value)
                {
                    m_titulo = value;
                    OnPropertyChanged("Titulo");
                    
                }
            }
        }

        public string Ano
        {
            get
            {
                return m_ano;
            }

            set
            {
                if (m_ano != value)
                {
                    m_ano = value;
                    OnPropertyChanged("Ano");
                }
            }
        }

        public string Genero
        {
            get
            {
                return m_genero;
            }

            set
            {
                if (m_genero != value)
                {
                    m_genero = value;
                    OnPropertyChanged("Genero");
                }
            }
        }
    }
}
