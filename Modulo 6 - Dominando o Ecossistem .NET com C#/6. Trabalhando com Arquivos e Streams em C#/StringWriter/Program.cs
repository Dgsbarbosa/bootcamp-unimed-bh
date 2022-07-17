System.Console.WriteLine("String Writer");

string textReaderText = "Lorem Ipsum" +
"Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...\n\n" +
"There is no one who loves pain itself, who seeks after it and wants to have it, simply because it is pain...\n\n" +
"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed nec nisl vulputate, tincidunt dolor vitae, porta enim. Nullam scelerisque erat urna, ut sagittis lectus placerat a. \n\nCras aliquam elit eu arcu vehicula, sed laoreet sapien tristique. Sed libero neque, ullamcorper sed ipsum in, euismod convallis neque. Vivamus tincidunt suscipit mollis. Phasellus sapien eros, congue eget finibus non, rhoncus vel ex. \n\nPraesent finibus est ac nisl finibus semper. Morbi luctus vehicula ultricies.\n\n Nunc a porta ante, id sollicitudin lacus. \n\nInteger in faucibus erat, a scelerisque diam.";


Console.WriteLine($"Texto Original: {textReaderText}");
System.Console.WriteLine();
string linha, paragrafo = null;
var sr = new StringReader(textReaderText);

while(true)
{
    linha = sr.ReadLine();
    if(linha != null)
    {
        paragrafo += linha + " ";
    }
    else
    {
        paragrafo += '\n';
        break;
    }

}

Console.WriteLine($"Texto Modificado: {paragrafo}");
System.Console.WriteLine();
int caractereLido;
char caracterConvertido;

var sw = new StringWriter();
sr = new StringReader(paragrafo);

while(true)
{
    caractereLido = sr.Read();
    if(caractereLido == -1) break;

    caracterConvertido = Convert.ToChar(caractereLido);

    if(caracterConvertido == '.')
    {
        sw.Write("\n\n");
        sr.Read();
        sr.Read();
        
    }
    else
    {
        sw.Write(caracterConvertido);
    }

   
};
 System.Console.WriteLine($"Texto armazenado StringWriter: {sw.ToString()} ");

System.Console.WriteLine("\n\nTecle [enter] para finalizar...");
Console.ReadLine();