

using LerUmArquivoJson;
using System.Text.Json;
using System.Text.Json.Nodes;

string path = @"C:\\Projetos\\c#\\LerUmArquivoJson\\teste.json";

string arquivo = File.ReadAllText(path);

Pessoas pessoas = JsonSerializer.Deserialize<Pessoas>(arquivo)!;

Console.WriteLine($"{pessoas.nome}");