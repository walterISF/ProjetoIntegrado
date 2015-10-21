using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_B
{
    class usuarioLogado
    {
        static string usuario;
        static string senha;

        public void setLogin(string usr)
        {
            usuario = usr;
        }
        public void setPassword(string psd)
        {
            senha = psd;
        }
        public string getLogin()
        {
            return usuario;
        }
        public string getPassword()
        {
            return senha;
        }
    }
}
