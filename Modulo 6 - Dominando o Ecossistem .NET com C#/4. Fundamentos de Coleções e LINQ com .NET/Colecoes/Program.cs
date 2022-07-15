using System;
using System.Collections.Generic;
using System.Linq;


namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {   
            
        
            
            //Listas
            System.Console.WriteLine();
            List<string> estados = new List<string>();
            estados.Add("SP");
            estados.Add("MG");
            estados.Add("BA");
            estados.Add("CE");
            
            System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}\n");

            //lISTANDO OS ESTADOS
            foreach (var item in estados)
            {
                System.Console.WriteLine(item,"\n");
            }

            for (int i = 0; i < estados.Count; i++)
            {
                System.Console.WriteLine($"Indice: {i}, Valor: {estados[i]}\n");
            }



            //Trabalhando com Arrrays

            int[] arrayInteiro = new int[4];

            arrayInteiro[0] = 10;
            arrayInteiro[1] = 20; 
            arrayInteiro[2] = 30;
            arrayInteiro[3] = 40;

            Console.WriteLine("Percorrendo o array com For");

            for (int i = 0; i < arrayInteiro.Length; i++)
            {
                Console.WriteLine(arrayInteiro[i]);
            } 

        //Pilhas    

            System.Console.WriteLine("\nTrabalhando com Pilhas (stack)\n");

            Stack<string> pilhaLivros = new Stack<string>();

            pilhaLivros.Push(".Net");
            pilhaLivros.Push("DDD");
            pilhaLivros.Push("Código Limpo");

                System.Console.WriteLine($"Livros na estante para leitura: {pilhaLivros.Count}\n");
            
            while (pilhaLivros.Count > 0)

                
            {
                System.Console.WriteLine($"Proximo livro para leitura: {pilhaLivros.Peek()}");
                System.Console.WriteLine($" {pilhaLivros.Pop()} lido com sucesso\n");
            }

            System.Console.WriteLine($"Livros na estante para leitura: {pilhaLivros.Count}\n");

            //Filas
            System.Console.WriteLine("Tabalhando com Filas");
            Queue<string> fila = new Queue<string>();

            fila.Enqueue("Douglas");
            fila.Enqueue("Sabrina");
            fila.Enqueue("Eduarda");
            fila.Enqueue("Leonardo");
            fila.Enqueue("Victória");

            //Usando Count
            System.Console.WriteLine($"Pessoas na Fila: {fila.Count} pacientes aguardando\n");

            while (fila.Count > 0)
            {
                //Usando Peek
                System.Console.WriteLine($"Chamando Paciente: {fila.Peek()}\n");

                //Usando Dequeue
                System.Console.WriteLine($" Paciente: {fila.Dequeue()} - atendido\n");
            }
            System.Console.WriteLine($"Pessoas na Fila: {fila.Count} pacientes aguardando\n");
        
            //Dicionarios

            Dictionary<string,string> estadosBr = new Dictionary<string,string>();

                //Adicionando no dicionario, são doi parametros chave e valor

                estadosBr.Add("SP", "São Paulo");
                estadosBr.Add("MG", "Minas Gerais");
                estadosBr.Add("BA", "Bahia");

                foreach (KeyValuePair<string,string> item in estadosBr)
                {
                    System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
                }

                //Acessando um valor no dicionário

                string valorProcurado = "SP"; //chave

                System.Console.WriteLine($"\nValor Original:");
                System.Console.WriteLine(estadosBr[valorProcurado]); //valor procurado

                //Atualizando um valor
                estadosBr[valorProcurado] = "BA - teste de atualização"; // Atualizando valor

                System.Console.WriteLine($"\nValor Atualizado:");
                System.Console.WriteLine(estadosBr[valorProcurado]);

                //Removendo um valor
                    System.Console.WriteLine("\nRemovendo um valor\n");

                    foreach (KeyValuePair<string,string> item in estadosBr)
                {
                    System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
                }

                    System.Console.WriteLine($"\nRemovendo o valor: {valorProcurado}");
                    estadosBr.Remove(valorProcurado);

                    foreach (KeyValuePair<string,string> item in estadosBr)
                {
                    System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
                }

                //Acessando de forma segura
                    System.Console.WriteLine("\nAcessando de forma segura\n");
                
                var valorProcurado2 = "BA";
                if (estadosBr.TryGetValue(valorProcurado2, out string estadoEncontrado))
                {
                    System.Console.WriteLine($"A Chave: {valorProcurado2} foi encontrada com o valor: {estadoEncontrado}");

                }else
                {
                    System.Console.WriteLine($"Chave {valorProcurado} não existe no dicinonário");
                }

            //Linq

            //Obtendo e ordenando valores com LINQ

            System.Console.WriteLine("\nObtendo e ordenando valores com LINQ\n");

            int[] arrayNumeros = new int[10] {100,1,4,8,0,19,4,100,15,19};

                //com query
                var numerosParesQuery = 
                    from num in arrayNumeros
                    where num %2 ==0
                    orderby num
                    select num;

                //com metodo

                var numerosParesMetodo = arrayNumeros.Where(x => x%2 == 0).OrderBy(x=>x).ToList();

                System.Console.WriteLine("Numeros pares query: " + string.Join(", ",numerosParesQuery));

                System.Console.WriteLine("Numeros pares metodo: " + string.Join(", ",numerosParesMetodo));

                //Valores mínimo, máximo e médio com LINQ

                System.Console.WriteLine("\nValores mínimo, máximo e médio com LINQ\n");

                var minimo = arrayNumeros.Min();
                var maximo = arrayNumeros.Max();
                var medio = arrayNumeros.Average();

                System.Console.WriteLine("Nosso array é: " + string.Join(", ",arrayNumeros));
                System.Console.WriteLine($"O valor minimo do array é: {minimo}");
                System.Console.WriteLine($"O valor maximo do array é: {maximo}");
                System.Console.WriteLine($"O valor medio do array é: {medio}\n");

                //Sum e Distinct

                System.Console.WriteLine("Sum e Distinct\n");

                var soma = arrayNumeros.Sum(); //Sum
                var arrayUnico = arrayNumeros.Distinct().ToArray(); //Distinct
                
                System.Console.WriteLine("Nosso array é: " + string.Join(", ",arrayNumeros));
                System.Console.WriteLine($"A soma do nosso array é: {soma}");
                System.Console.WriteLine($"Array distinto: {string.Join(", ",arrayUnico)}");
            







        }
    }
}
