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
        static string nome;
        static string nascimento;

        public void setLogin(string usr)
        {
            usuario = usr;
        }
        public void setPassword(string psd)
        {
            senha = psd;
        }
        public void setName(string name)
        {
            nome = name;
        }
        public void setBirth(string birth)
        {
            nascimento = birth;
        }
        //-------------------------------------------------------------
        public string getLogin()
        {
            return usuario;
        }
        public string getPassword()
        {
            return senha;
        }
        public string getName()
        {
            return nome;
        }
        public string getBirth()
        {
            return nascimento;
        }
    }
}
