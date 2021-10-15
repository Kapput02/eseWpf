using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eseWpf.Classi
{
    class Utente
    {
        private string _Username;
        private string _Password;
        private string _NomeCompleto;
        public Utente(string username,string password,string nomeCompleto)
        {
            _Username = username;
            _Password = password;
            _NomeCompleto = nomeCompleto;
        }
        public string Username 
        {
            get
            {
                return this._Username;
            }
            set
            {
                this._Username = value;
            }
        }
        public string Password
        {
            get
            {
                return this._Password;
            }
            set
            {
                this._Password = value;
            }
        }
        public string NomeCompleto
        {
            get
            {
                return this._NomeCompleto;
            }
            set
            {
                this._NomeCompleto = value;
            }
        }
    }
}
