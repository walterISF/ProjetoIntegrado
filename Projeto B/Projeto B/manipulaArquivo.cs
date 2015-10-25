using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projeto_B
{
    class manipulaArquivo
    {
        private static string pathFile = @"c:/temp/usuarios.txt";
        
        StreamReader ler = new StreamReader(pathFile);
        StreamWriter esc = new StreamWriter(pathFile, true);

        public void criarArquivo()
        {
            FileStream criar = File.Create(pathFile);
        }
        public void escreverArquivo(string frase)
        {
            esc.WriteLine(frase);
            esc.Close();
        }
        public void lerArquivo(int linha)
        {
            string leu = ler.ReadLine();
            
        }
    }
}
