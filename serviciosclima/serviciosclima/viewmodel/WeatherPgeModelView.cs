using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace serviciosclima.viewmodel
{
    class WeatherPgeModelView : notificable
    {
        #region atributos
        private string ubicacion;
        private string pais;
        private string resultTerm;
        private string region;
        private string ultimaactualizacion;
        private string clima;
        private string temperatura;
        private ImageSource image;

        #endregion
        #region propiedades
        public string Region
        {
            get
            {
                return region;
            }
            set
            {
                SetValue(ref region, value);
            }
        }

        public string UltimaActualizacion
        {
            get
            {
                return ultimaactualizacion;
            }
            set
            {
                SetValue(ref ultimaactualizacion, value);
            }
        }
        public string Clima
        {
            get
            {
                return clima;
            }
            set
            {
                SetValue(ref clima, value);
            }
        }

        public string Temperatura
        {
            get
            {
                return temperatura;
            }
            set
            {
                SetValue(ref temperatura, value);
            }
        }

        public string Ubicacion
        {
            get
            {
                return ubicacion;
            }
            set
            {
                SetValue(ref ubicacion, value);
            }
        }
        public string Pais
        {
            get
            {
                return pais;
            }
            set
            {
                SetValue(ref pais, value);
            }
        }
        public string ResultTerm
        {
            get
            {
                return resultTerm;
            }
            set
            {
                SetValue(ref resultTerm, value);
            }
        }
        public ImageSource Imagen
        {
            get
            {
                return image;
            }
            set
            {
                SetValue(ref image, value);
            }
        }
        #endregion

        #region comadoso
        public  ICommand BuscarCommand
        {
            get
            {
                return new RelayCommand(Buscar);
            }
        }

        #endregion
        #region
        public WeatherPgeModelView()
        {

        }
        #endregion

        #region METODOS

        private void Buscar()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
