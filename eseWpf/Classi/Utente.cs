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
        private string _Info;
        public Utente(string username,string password,string nomeCompleto)
        {
            _Username = username;
            _Password = password;
            _NomeCompleto = nomeCompleto;
            _Info = _NomeCompleto + _Username;
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
        public string Info
        {
            get
            {
                return this._Info;
            }
            set
            {
                this._Info = this._NomeCompleto+this._Username;
            }
        }
    }
}
