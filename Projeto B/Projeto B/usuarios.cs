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
       
        //--------------------------------------------------------------
        public static string local = @"c:/temp/usuarios.txt";
        public static string arqMorto = @"c:/temp/arqMorto.txt";
        public static string arqTmp = @"c:/temp/arqTmp.txt";
        
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
            while((leitura = ler.ReadLine()) != null)
            {
                string [] user = leitura.Split(';');
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
        public string lerUltimoUser()
        {
            StreamReader ler = new StreamReader(local);
            string aux = ler.ReadToEnd();
            string[] usuario = aux.Split('\n');
            ler.Close();
            return usuario[usuario.Length-2];
        }
        /*
         * 0 - cod usuario
         * 1 - status   1-normal 2-bloqueado 3-senha inicial
         * 2 - perfil   1-administrador 2-operador 3-auxiliar
         * 3 - nome
         * 4 - nascimento
         * 5 - psw atual
         * 6 - psw anterior
         * 7 - psw data da alteração
         */

        //---------------------------------------------------------------------

        public void trocarSenha(int codUser, string novaSenha)
        {
            StreamReader ler = new StreamReader(local);
            StreamWriter escrever = new StreamWriter(arqMorto);
            StreamWriter arqTemp = new StreamWriter(arqTmp);
            string usuario = lerUsuario(codUser);
            string[] user = usuario.Split(';');
            escrever.WriteLine("Alteração de Senha: " + usuario);
            user[1] = "1";
            user[6] = user[5];
            user[5] = novaSenha;
            string nSenha = user[0] + ";" + user[1] + ";" + user[2] + ";" + user[3] + ";" + user[4] + ";" + user[5] + ";" + user[6] + ";" + user[7];
            string leitura;
            while((leitura = ler.ReadLine()) != null)
            {
                string[] aux = leitura.Split(';');
                if (!(int.Parse(aux[0]) == codUser))
                {
                    arqTemp.WriteLine(leitura);
                }
                else
                {
                    arqTemp.WriteLine(nSenha);
                }
            }

            ler.Close();
            escrever.Close();
            arqTemp.Close();

            File.Delete(local);
            File.Copy(arqTmp, local);
            File.Delete(arqTmp);
        }
        
    }
}
