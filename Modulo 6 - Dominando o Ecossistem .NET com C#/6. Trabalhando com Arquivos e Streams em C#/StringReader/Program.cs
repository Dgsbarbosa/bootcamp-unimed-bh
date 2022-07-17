using System.Text;

var sb = new StringBuilder();
sb.AppendLine("Caracteres na primeira linha para ler");
sb.AppendLine("segunda linha");
sb.AppendLine("fim");


using var sr = new StringReader(sb.ToString());

var buffer = new char[10]; // define a quantidade de bits a serem lidos

var tamanho = 0;

//ReadToEnd(); // le todo o texto

//ReadLine();

//var textoBuffer = sr.Read(buffer); //usando a quantidades de caractere definidos

do
{
    buffer = new char[10];
    tamanho = sr.Read(buffer);
    Console.Write(string.Join("", buffer));
}while(tamanho >= buffer.Length);

Console.WriteLine("Digite[enter] para finalizar");
Console.ReadKey();
