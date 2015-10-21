using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_B
{
    class usuarios
    {
        //Variaveis para teste

            int ind = -1;
            static string[] usuario_teste = new string[3]{
            "Padrao111",
            "Padrao222",
            "Padrao333"};
            static string[] senha_teste = new string[3]{
            "Pdr111",
            "Pdr222",
            "Pdr333"};

        public string findPassword(int i)
        {
            return senha_teste[i];
        }
        public int findLogin(string usr)
        {
            int i=0;
            while ( i < 3)
            {
                if (usr == usuario_teste[i])
                {
                    return i;
                }
                else
                    i++;
            }
            if (i > 3)
            {
                return -1;
            }
            else
                return i;
        }
        public void changePassword(int i, string newPassword)
        {
            senha_teste[i] = newPassword;
        }
    }
}
