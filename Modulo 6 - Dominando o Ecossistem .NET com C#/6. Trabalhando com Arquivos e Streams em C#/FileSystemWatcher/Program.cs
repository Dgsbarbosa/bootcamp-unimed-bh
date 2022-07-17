System.Console.WriteLine("File System Watcher");

//criando variavel para eventos
var path = @"C:\Users\Douglas\Documents";

using var fsw = new FileSystemWatcher(path);

fsw.Created += Oncreated;
fsw.Renamed += OnRenamed;
fsw.Deleted += OnDeleted;

fsw.EnableRaisingEvents = true; //para que o seja feito o disparo do evento
fsw.IncludeSubdirectories= true;

System.Console.WriteLine($"Monitrando eventos da pasta {path}");
Console.WriteLine("Pressione [enter] para finalizar");
Console.ReadLine();

//o parametro "e" pega o arquivo que disparou o evento
void Oncreated(object sender, FileSystemEventArgs e)
{
    System.Console.WriteLine($"Foi criado o arquivo {e.Name}");
}

void OnDeleted(object sender, FileSystemEventArgs e)
{
    System.Console.WriteLine($"Foi excluido o arquivo{e.Name}");}

void OnRenamed(object sender, RenamedEventArgs e)
{
    System.Console.WriteLine($"O aqrquivo {e.OldName} foi renomeado para {e.Name}");
}