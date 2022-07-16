// importando o System Console, usado para que não seja necessario escrever console
using static System.Console;

//importando System.IO
using System.IO;

/*
//Criando arquivo

var path = Path.Combine(Environment.CurrentDirectory, "teste.txt");
File.Create(path);
*/


//Criando arquivo com texto onde o usuario escolhe o nome do arquivo

WriteLine("Digite o nome do arquivo");

var nomeArquivo = ReadLine();

WriteLine("Digite a extenção desejada (sem ponto)! EX.: doc, txt, html, ...");
var extensao = ReadLine();

//tratando caracteres invalidos e trocando por '-'
foreach (var caracter in Path.GetInvalidFileNameChars())
{
    nomeArquivo = nomeArquivo.Replace(caracter, '-');
}


var path2 = Path.Combine(Environment.CurrentDirectory, $"{nomeArquivo}.{extensao}");

CriarArquivo(path2);


static void CriarArquivo(string path2)
{
    try
    {
        using var sw = File.CreateText(path2);
        sw.WriteLine("Esta é a linha 1 do nosso File.CreateText");
        sw.WriteLine("Esta é a linha 2 do nosso File.CreateText");
        sw.WriteLine("Esta é a linha 3 do nosso File.CreateText");
    }
    catch
    {

        WriteLine("O nome do arquivo é inválido");
        WriteLine("Evite caracteres especiais");
    }

    WriteLine("Digite enter para finalizar");

}


