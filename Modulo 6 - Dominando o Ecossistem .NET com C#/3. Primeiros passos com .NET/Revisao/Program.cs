using System;

namespace Revisao
{
    class Program
    {
        //criação de menu para usuario 
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];

            var indiceAluno = 0;

            string opcaoUsuario = ObterOpcaoUsuario();
           

           while (opcaoUsuario.ToUpper() != "X")
           {
                switch (opcaoUsuario)
                {
                    case "1":
                        // TODO: adicionar aluno
                        Console.WriteLine("Informe o nome do Aluno:");
                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno:");

                        if(decimal.TryParse( Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }

                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal");
                        }
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        Console.WriteLine($"Aluno: {aluno.Nome} \nNota: {nota} \nFoi cadastrado com sucesso");

                        break;
                    
                    case "2":
                        //TODO: listar alunos

                        foreach (var student in alunos)
                        {
                            if(!string.IsNullOrEmpty(student.Nome)){
                            Console.WriteLine($"Aluno: {student.Nome} - Nota: {student.Nota}");    
                        }
                        }

                        break;
                    
                    case "3":
                        //TODO: calcular média
                        
                        Console.WriteLine("Opção 3\n");
                        break;
                    
                    default:

                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
           }
           }
           private static string ObterOpcaoUsuario()
                {
                    Console.WriteLine("\nInforme a opção desejada");
                    Console.WriteLine("1- Inserir novo aluno");
                    Console.WriteLine("2- Listar alunos");
                    Console.WriteLine("3- Calcular média geral");
                    Console.WriteLine("X- Sair");
                    
                    string opcaoUsuario = Console.ReadLine();
                    return opcaoUsuario;
                }
        
    }
}
