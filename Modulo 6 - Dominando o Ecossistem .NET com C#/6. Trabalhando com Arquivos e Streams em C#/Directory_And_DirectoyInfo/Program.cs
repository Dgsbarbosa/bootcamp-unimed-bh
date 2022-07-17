// variaveis globais

    //criando variavel de origem e destino
    var origem = Path.Combine(Environment.CurrentDirectory,"brasil.txt");

    var destino = Path.Combine(Environment.CurrentDirectory, "globo", "America do Sul","Brasil","brasil.txt");

    //criando variavel para LerDiretorios();
    var pathLerDiretorios = @"C:\Users\Douglas\Downloads\Directory_And_DirectoyInfo";

//Chamando os metodos
CriarDiretoriosGlobo();

CriarArquivos();

MoverArquivo(origem, destino);

CopiarArquivos(origem, destino);

LerDiretorios(pathLerDiretorios);

LerArquivos(pathLerDiretorios);



//Metodos

//metodo criar diretorios
static void CriarDiretoriosGlobo(){
System.Console.WriteLine("\nMetodo criar diretorios");
//variavel para criação do nome
var path = Path.Combine(Environment.CurrentDirectory, "globo");
if(!Directory.Exists(path)){
//criando o diretorio
var dirGlobo = Directory.CreateDirectory(path);

//criando subdiretorios para regioes

var dirAmNorte = dirGlobo.CreateSubdirectory("America do Norte");

var dirAmSul = dirGlobo.CreateSubdirectory("America do Sul");

var dirAmCentral = dirGlobo.CreateSubdirectory("America do Central");

//criando subdiretorio para paises

dirAmNorte.CreateSubdirectory("USA");
dirAmNorte.CreateSubdirectory("Mexico");
dirAmNorte.CreateSubdirectory("Canada");

dirAmCentral.CreateSubdirectory("Costa Rica");
dirAmCentral.CreateSubdirectory("Panama");

dirAmSul.CreateSubdirectory("Brasil");
dirAmSul.CreateSubdirectory("Argentina");
dirAmSul.CreateSubdirectory("Paraguai");
}
}

// metodo criar arquivo
static void CriarArquivos()
{
    System.Console.WriteLine("\nMetodo criar arquivo");
    var path = Path.Combine(Environment.CurrentDirectory, "brasil.txt");

    System.Console.WriteLine();
    if(!File.Exists(path)){
    using var sw = File.CreateText(path);
    sw.WriteLine("População: 220 milhões");
    sw.WriteLine("IDH: 0,901");
    sw.WriteLine("Dados atualizados em : 20/04/2018");
    }else{
        System.Console.WriteLine("O arquivo já existe");
        System.Console.WriteLine();
    }
}

// metodo mover arquivo
static void MoverArquivo(string pathOrigem, string pathDestino){
    System.Console.WriteLine("\nMetodo mover arquivo");
    if(!File.Exists(pathOrigem)){
        Console.WriteLine("Arquivo de Origem não existe");
        return;
}
    if(File.Exists(pathDestino)){
        Console.WriteLine("Arquivo já existe na pasta de destino");
        System.Console.WriteLine();
        return;
    }
    File.Move(pathOrigem,pathDestino);
}

// metodo copiar
static void CopiarArquivos(string pathOrigem, string pathDestino){
    System.Console.WriteLine("\nMetodo Copiar");
     if(!File.Exists(pathOrigem)){
        Console.WriteLine("Arquivo de Origem não existe");
        return;
}
    if(File.Exists(pathDestino)){
        Console.WriteLine("Arquivo já existe na pasta de destino");
        return;
    }
    File.Copy(pathOrigem,pathDestino);
}

//metodo para Ler diretorios

static void LerDiretorios(string path){
    System.Console.WriteLine("\nMetodo Ler Diretorios");
    if(Directory.Exists(path)){
    var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

    foreach (var dir in diretorios)
        {
            var dirInfo = new DirectoryInfo(dir);
            System.Console.WriteLine($"[Nome]: {dirInfo.Name}");
            System.Console.WriteLine($"[Raiz]: {dirInfo.Root}");

            if(dirInfo.Parent != null){
            System.Console.WriteLine($"[Pai]: {dirInfo.Parent.Name}");
            }

            System.Console.WriteLine("-------------");
        }
    }
    else{
        System.Console.WriteLine("O diretorio não existe");
    }
}

//metodo Ler Arquivos
static void LerArquivos(string path){

    System.Console.WriteLine();
    System.Console.WriteLine("Metodo Ler Arquivos");
    var arquivos = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
    foreach (var arquivo in arquivos)
    {
        var fileInfo = new FileInfo(arquivo);
        System.Console.WriteLine($"[Nome]: {fileInfo.Name}"); 
        System.Console.WriteLine($"[Tamanho]: {fileInfo.Length}"); 
        System.Console.WriteLine($"[Ultimo acesso]: {fileInfo.LastAccessTime}"); 
        System.Console.WriteLine($"[Pasta]: {fileInfo.DirectoryName}"); 
        System.Console.WriteLine("----------------");
    }
}









