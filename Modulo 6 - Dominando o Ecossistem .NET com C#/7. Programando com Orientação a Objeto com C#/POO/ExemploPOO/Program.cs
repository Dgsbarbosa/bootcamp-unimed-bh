using System;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;
using System.IO;


namespace ExemploPOO
{
    class Program
{
        
        
        static void Main(string[] args)
        {
            //chamada dos metodos criados
            Abstração();
            Encapsulamento();
            Heranca();
            Polimorfismo();
            ClassesAbstratas();
            MetodosSelados();
            ClasseObject();
            Interfaces();
            ListarDiretorios();
            ListarArquivos();
            CriarDiretorio();
            ApagarDiretorio();

        //Abstração
            static void Abstração(){
            System.Console.WriteLine("Abstração\n--------------");
            Pessoa p1 = new Pessoa();
            p1.Nome = "Douglas";
            p1.Idade = 34;
            p1.Documento = "32659545";
            p1.Apresentar();}

        //Encapsulamento           
            static void Encapsulamento(){
            System.Console.WriteLine("\n");    
            System.Console.WriteLine("Encapsulamento\n--------------");

            //valores validos
            System.Console.WriteLine("Teste com valores validos");
            Retangulo r = new Retangulo();

            r.DefinirMedidas(30,30);            
            
            System.Console.WriteLine($"Area: {r.ObterArea()}");
            System.Console.WriteLine("\n");

            //valores invalidos
            System.Console.WriteLine("Teste com valores invalidos");
            Retangulo r2 = new Retangulo();

            r2.DefinirMedidas(-30,30);            
            
            System.Console.WriteLine($"Area: {r2.ObterArea()}");
            System.Console.WriteLine("\n");
            }
            
        //Herança
            static void Heranca(){
                System.Console.WriteLine("Herança\n--------------");
                //Método para aluno
                System.Console.WriteLine("Método para aluno");
                Aluno a1 = new Aluno();
                a1.Nome = "Douglas";
                a1.Idade = 34;
                a1.Nota = 10;

                a1.Apresentar();
                System.Console.WriteLine("\n");

                //Método para professor
                System.Console.WriteLine("Método para Professor");
                Professor t1 = new Professor();
                t1.Nome = "Lucio";
                t1.Idade = 43;
                t1.Salario = 5000;
                t1.Documento = "2123132123";
                t1.Apresentar();
                System.Console.WriteLine();               
                
            }   

        // Polimorfismo
        static void Polimorfismo()
        {
        System.Console.WriteLine("Polimorfismo em tempo de compilação\n--------------");          
        Calculadora calc = new Calculadora();
        System.Console.WriteLine($"Resultado da primeira soma: {calc.Somar(5,2)}");
        System.Console.WriteLine($"Resultado da segunda soma: {calc.Somar(5,2,5)}");

        System.Console.WriteLine("\n");

        }
        
        //Classes e Metodos Abstratos
        static void ClassesAbstratas()
        {
            System.Console.WriteLine("Classes e Metodos Abstratos\n--------------");
            Corrente c = new Corrente();
            c.Creditar(100);
            c.ExibirSaldo(); 

            System.Console.WriteLine();          


        }
        
        // Classes e Metodos selados
        static void MetodosSelados()
        {

        }
        
        //Classe System.Object
        static void ClasseObject()
        {
            System.Console.WriteLine("ClasseObject\n--------------");

            Computador comp = new Computador();

            //usando o ToString()
            System.Console.WriteLine($"Retorno no metodo ToString():\n{comp.ToString()}");


            System.Console.WriteLine();
        }

        //Interfaces
        static void Interfaces()
        {
            System.Console.WriteLine("Interfaces\n--------------");

            ICalculadora calc = new Calculadora();

            var n1 = 10;
            var n2 = 5;
            System.Console.WriteLine($"A soma de{n1} + {n2} = {calc.Somar(n1,n2)}");
            System.Console.WriteLine($"A subtração de {n1} - {n2} = {calc.Subtrair(n1,n2)}");
            System.Console.WriteLine($"A multiplicação de {n1} x {n2} = {calc.Multiplicar(n1,n2)}");;
            System.Console.WriteLine($"A divisão de {n1} - {n2} = {calc.Dividir(n1,n2)}");


            System.Console.WriteLine();
        }

        //Listar Diretorios
        static void ListarDiretorios()
        {
            System.Console.WriteLine("Listando os ditetórios\n--------------");
            var caminho = @"C:\\Users\Douglas\Downloads\TrabalhandoComArquivos";
            FileHelper helper =  new FileHelper();
            helper.ListarDiretorios(caminho);

            System.Console.WriteLine();
        }

        // Listar Arquivos
          static void ListarArquivos()
        {
           System.Console.WriteLine("Listar Arquivos \n------------------");
           
           var caminho = @"C:\Users\Douglas\Downloads\TrabalhandoComArquivos";

           FileHelper helper2 = new FileHelper();

           helper2.ListarArquivosDiretorios(caminho);

           System.Console.WriteLine();
        }


        //Criar Diretorios
         static void CriarDiretorio()
        {
           System.Console.WriteLine(" Criar diretórios\n------------------");

           var caminho = @"C:\Users\Douglas\Downloads\TrabalhandoComArquivos";

           System.Console.WriteLine("Qual o nome da pasta?");

            string? nomePasta = Console.ReadLine();

           var caminhoPathCombine = Path.Combine(caminho, nomePasta, "Subpasta" + nomePasta);

           FileHelper helper = new FileHelper();

           System.Console.WriteLine("Criando diretório " + caminhoPathCombine); 
           helper.CriarDiretorio(caminhoPathCombine);


           System.Console.WriteLine("\nDiretório criado com sucesso");
           
           System.Console.WriteLine();
        }

        // Deletar diretorio
        static void ApagarDiretorio()
        {
            System.Console.WriteLine("Deletar diretórios\n------------------");

            var caminho = @"C:\Users\Douglas\Downloads\TrabalhandoComArquivos";

            
            
            System.Console.WriteLine("Qual o nome da pasta que deseja excluir");
            string nomePasta = Console.ReadLine();

            var caminhoPathCombine = Path.Combine(caminho,nomePasta);

            FileHelper helper = new FileHelper();          
            
            System.Console.WriteLine("Deseja excluir o diretório");
            var resposta = Console.ReadLine();

            if (resposta == "s"){
            helper.ApagarDiretorio(caminhoPathCombine, true);

           System.Console.WriteLine("\nDiretório deletado com sucesso com sucesso");
            }
            else{
                return;
            }
            System.Console.WriteLine();
        }


        
        }
        
}


}

/*
    static void ()
        {
           System.Console.WriteLine(" \n------------------");

           System.Console.WriteLine();
        }
        
*/