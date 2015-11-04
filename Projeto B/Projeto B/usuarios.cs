using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        static string[] nome_teste = new string[3]{
            "Allan Guerra",
            "Walter Inacio Silva Filho",
            "Bianca Amarante Magalhaes"};
        static string[] nascimento_teste = new string[3]{
            "06/04/1990",
            "15/08/1994",
            "19/08/1982"};
        //--------------------------------------------------------------
        public static string local = @"c:/temp/usuarios.txt";
        
        //CRUD Usuarios

        public void criarUsuario(string user)
        {
            StreamWriter gravar = new StreamWriter(local, true);
            gravar.WriteLine(user);
            gravar.Close();
        }
        public string lerUsuario(int codUser)
        {
            StreamReader ler = new StreamReader(local);
            string leitura;
            while((leitura = ler.ReadLine()) != ""){
                string [] user = new string[8];
                user = leitura.Split(';');
                int cod = int.Parse(user[0]);
                if (cod == codUser)
                {
                    ler.Close();
                    return leitura;
                }
            }
            ler.Close();
            return null;
        }
        /*
         * 0 - cod usuario
         * 1 - status
         * 2 - perfil
         * 3 - nome
         * 4 - nascimento
         * 5 - psw atual
         * 6 - psw anterios
         * 7 - psw data da alteração
         */

        //---------------------------------------------------------------------

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
            return -1;          
        }
        public string findName(int i)
        {
            return nome_teste[i];
        }
        public string findBirth(int i)
        {
            return nascimento_teste[i];
        }
        public void changePassword(int i, string newPassword)
        {
            senha_teste[i] = newPassword;
        }
    }
}
