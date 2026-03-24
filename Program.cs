

using LerUmArquivoJson;
using System.Text.Json;
using System.Text.Json.Nodes;

string path = @"C:\\Projetos\\c#\\LerUmArquivoJson\\teste.json";
string path2 = @"C:\Projetos\c#\LerUmArquivoJson\arquivo2";

string arquivo = File.ReadAllText(path);
string arquivo2 = File.ReadAllText(path2);

Pessoas pessoas = JsonSerializer.Deserialize<Pessoas>(arquivo2)!;

Console.WriteLine($"Nome: {pessoas.nome} Idade: {pessoas.idade} Email: {pessoas.email}");