
using OpenAI_API;
using OpenAI_API.Completions;
using OpenAI_API.Models;
using System.Text;

Console.WriteLine("Nomeie meu animal de estimação");
Console.WriteLine("Digite o animal desejado:");


string animal;
animal = Console.ReadLine();

StringBuilder sb = new StringBuilder();

sb.Append("Sugira três nomes para um animal que seja um super-herói.");
sb.Append("Animal: Gato");
sb.Append("Nomes: Capitão Garra Afiada, Agente Peludinho, O Incrível Felino");
sb.Append("Animal: Cachorro");
sb.Append("Nomes: Ruff o Protetor, Canino Maravilha, Sir Latidos");
sb.Append("Animal: " + animal);
sb.Append("Nomes:");

string prompt = sb.ToString();


string apiKey = "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";


OpenAIAPI api = new OpenAIAPI(new APIAuthentication(apiKey));

CompletionRequest request = new CompletionRequest(prompt, model: Model.DavinciText, max_tokens:2049, temperature: 0.6);

var result = await api.Completions.CreateCompletionAsync(request);

Console.WriteLine(result.ToString());





