using construtores.models;
using System;


internal class Program
{
    //chamada do delegate
    public delegate void Operacao(int x , int y);
    private static void Main(string[] args)
    {
        //Chamada dos metodos
        Construtores();
        ContrutorPrivado();
        ConstrutorHerança();
        GetSet();
        Delegate();
        Eventos();

        //Construtores
        static void Construtores()
        {
            Console.WriteLine("Construtores\n--------------");
            Pessoa p1 = new Pessoa("Douglas", "Barbosa");
            p1.Apresentar();

            Console.WriteLine();
        }

        //Contrutor Privado
        static void ContrutorPrivado()
        {
            Console.WriteLine("Contrutor Privado\n--------------");

            Log log = Log.GetInstance();


            log.PropriedadeLog = "Teste Instância";

            Log log2 = Log.GetInstance();

            Console.WriteLine(log2.PropriedadeLog);

            Console.WriteLine();
        }

        // Construtor da Herança
        static void ConstrutorHerança()
        {
            Console.WriteLine("Construtor da Herança\n--------------");

            Aluno a1 = new Aluno("Douglas", "Barbosa", "Ciências da Computação");

            a1.Apresentar();
            Console.WriteLine();
        }

        //Get e Set
        static void GetSet()
        {
            Console.WriteLine("Getters e Setters\n--------------");
            Data data = new Data();
            data.SetMes(12);
            data.ApresentarMes();
            Console.WriteLine();
        }
        
        //Delegate
        static void Delegate()
        {
            Console.WriteLine("Delegate\n--------------");
            
            Operacao op = new Operacao(Calculadora.Somar);
            op += Calculadora.Subtrair;
            op += Calculadora.Multiplicação;
            op += Calculadora.Divisao;
            

            System.Console.WriteLine($"Chamando o delegate com Invoke\n");
            op.Invoke(10,2);

            System.Console.WriteLine();

            System.Console.WriteLine($"Chamando o delegate sem Invoke\n");
            op(20,10);


            /*
            Outra forma de chamar o delegate

            Operacao op = Calculadora.Somar;
            */
            Console.WriteLine();
        }
    
        //Eventos
        static void Eventos()
        {   
            System.Console.WriteLine("Eventos\n--------------");

            Matematica m = new Matematica(10,20);
            m.Somar();
            
            System.Console.WriteLine();
        }  
    
    
    
    }
}



//modelo
/*

//
static void ()
{   
    System.Console.WriteLine("\n--------------");
   
    
    System.Console.WriteLine();
}

*/