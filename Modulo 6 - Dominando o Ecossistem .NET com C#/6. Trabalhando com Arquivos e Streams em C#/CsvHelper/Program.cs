using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;

System.Console.WriteLine("Csv Helper com Dynamic\n-------");
LerCsvComDynamic();
System.Console.WriteLine("\n------------\n");
System.Console.WriteLine("Csv Helper com Classe\n-------");
LerCsvComClasse();



System.Console.WriteLine("Digite [enter] para finalizar");
Console.ReadLine();

// lendo csv com classe
static void LerCsvComClasse()
{
var path = Path.Combine(
    Environment.CurrentDirectory,
    "Entrada",
    "novos-usuarios.csv");

    var fi = new FileInfo(path);

    if (!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não existe");
    
    using var sr = new StreamReader(fi.FullName);

    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);

    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<Usuario>();

    foreach (var registro in registros)
    {
        System.Console.WriteLine($"nome:{registro.Nome}");
        System.Console.WriteLine($"marca:{registro.Email}");
        System.Console.WriteLine($"preço:{registro.Telefone}");
        System.Console.WriteLine("-----------------");
        
    }
    
}


//lendo csv com dynamic
static void LerCsvComDynamic(){
var path = Path.Combine(
    Environment.CurrentDirectory,
    "Entrada",
    "Produtos.csv");

    var fi = new FileInfo(path);

    if (!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não existe");
    
    using var sr = new StreamReader(fi.FullName);

    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);

    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<dynamic>();

    foreach (var registro in registros)
    {
        System.Console.WriteLine($"nome:{registro.Produto}");
        System.Console.WriteLine($"marca:{registro.Marca}");
        System.Console.WriteLine($"preço:{registro.Preco}");
        System.Console.WriteLine("-----------------");
        
    }

}    
