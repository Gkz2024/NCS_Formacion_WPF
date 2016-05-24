using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS_Formacion_WPF
{
    public class resultado
    {
        private List<Pelicula> search;

        public List<Pelicula> Search
        {
            get { return search; }
            set { search = value; }
        }

    }

    public class Pelicula : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

        }


        private string m_title;
        private string m_year;
        private string m_imdbID;
        private string m_type;
        private string m_poster;

        public string Title
        {
            get
            {
                return m_title;
            }

            set
            {
                if (m_title != value)
                {
                    m_title = value;
                    OnPropertyChanged("Title");
                }
            }
        }

        public string Year
        {
            get
            {
                return m_year;
            }

            set
            {
                m_year = value;
            }
        }

        public string ImdbID
        {
            get
            {
                return m_imdbID;
            }

            set
            {
                m_imdbID = value;
            }
        }

        public string Type
        {
            get
            {
                return m_type;
            }

            set
            {
                m_type = value;
            }
        }

        public string Poster
        {
            get
            {
                return m_poster;
            }

            set
            {
                m_poster = value;
            }
        }
    }
}
