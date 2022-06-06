using OrcamentoApp;
using OrcamentoApp.Model;
using System.Net.Http.Headers;
using System.Text.Json;

namespace OrcamentoApp
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("https://localhost:7204/Orcamento"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var streamTask = client.GetStreamAsync("https://localhost:7204/Orcamento");
            var repositories = await JsonSerializer.DeserializeAsync<List<Modelos>>(await streamTask);
            return;
        }
    }
}
