using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
           var retornoCaminho = Directory.GetDirectories(caminho, "*" ,SearchOption.AllDirectories);

           foreach (var retorno in retornoCaminho)
           {
            System.Console.WriteLine(retorno);
           }
        }

        public void ListarArquivosDiretorios(string caminho)
        {
            //retorna todos os arquivos
            var retornoArquivos = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories);

            //retorna apenas os arquivos .txt
             var retornoArquivos2 = Directory.GetFiles(caminho, "*.txt", SearchOption.AllDirectories);

            //retorna apenas os arquivos .png
             var retornoArquivos3 = Directory.GetFiles(caminho, "*.png", SearchOption.AllDirectories);



            System.Console.WriteLine("Retorna todos os arquivos");
            foreach (var retorno in retornoArquivos)
            {                
                System.Console.WriteLine(retorno);
                
            }System.Console.WriteLine();

            System.Console.WriteLine("Retorna apenas os arquivos .txt");
             foreach (var retorno in retornoArquivos2)
            {                
                System.Console.WriteLine(retorno);
               
            } System.Console.WriteLine("------");
                System.Console.WriteLine();

            System.Console.WriteLine("Retorna apenas os arquivos .png");
             foreach (var retorno in retornoArquivos3)
            {
                
                System.Console.WriteLine(retorno);
                
            }System.Console.WriteLine();
        }
    
        public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);

        }
    
    
        public void ApagarDiretorio(string caminho, bool apagarArquivos)
        {
            Directory.Delete(caminho, apagarArquivos );
        }
    
    
    }


}

/*
    public void ()
        {
           System.Console.WriteLine(" \n------------------");

           System.Console.WriteLine();
        }
        
*/