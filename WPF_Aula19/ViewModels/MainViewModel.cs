using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace WPF_Aula19.ViewModels
{
    public class MainViewModel:Screen
    {
        private string _nomeCompleto;

        public  string NomeCompleto
        {
            get { return _nomeCompleto; }
            set { _nomeCompleto = value; base.NotifyOfPropertyChange(() => NomeCompleto); }
        }

    }
}
