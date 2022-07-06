using System.Net.Http.Headers;

namespace OrcamentoApp
{
    public class RestClient : IRestClient
    {
        private readonly HttpClient cliente = new();
        private readonly string apiBaseUri = "https://localhost:7298/";

        public RestClient()
        {
            cliente.BaseAddress = new Uri(apiBaseUri);
            cliente.DefaultRequestHeaders.Accept.Clear();
            cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task ExecutarOrcamentoAsync(OrcamentoRequest orcamentoRequest)
        {
            HttpResponseMessage response = await cliente.PostAsJsonAsync("Orcamento", orcamentoRequest);

            if (response.IsSuccessStatusCode)
            {
                OrcamentoResponse orcamentoResponse = await response.Content.ReadAsAsync<OrcamentoResponse>();

                Console.WriteLine($"Seu orçamento está pronto:{Environment.NewLine}"+
                    $"Id: {orcamentoResponse.Id}{Environment.NewLine} " +
                    $"Nome produto: {orcamentoResponse.Produto.Nome} {Environment.NewLine}"+
                    $"Quantidade: {orcamentoRequest.QuantidadeProduto} {Environment.NewLine}"+
                    $"Nome Vendedor: {orcamentoResponse.Vendedor.Nome}{Environment.NewLine}"+
                    $"Valor Total R$: {orcamentoResponse.ValorTotal}{Environment.NewLine}");
            }
        }

        public async Task GetProdutoAsync()            
        {       
            // HTTP GET
            HttpResponseMessage response = await cliente.GetAsync("Produto");
            if (response.IsSuccessStatusCode)
            {
                List<Produto> listaProduto = await response.Content.ReadAsAsync<List<Produto>>();

                foreach (var elemento in listaProduto)
                {
                    Console.WriteLine(elemento.Nome);
                }
            }
        }

        public async Task ConsultaComissaoAsync(int id)
        {
            HttpResponseMessage response = await cliente.GetAsync($"Vendedor/{id}");
            
            if (response.IsSuccessStatusCode)
            {
                VendedorResponse vendedorResponse = await response.Content.ReadAsAsync<VendedorResponse>();

                Console.WriteLine($"Comissão do seu funcionário:{Environment.NewLine}" +
                    $"Id: {vendedorResponse.Id}{Environment.NewLine}" +
                    $"Nome: {vendedorResponse.Nome} {Environment.NewLine}" +
                    $"Comissão: {vendedorResponse.Comissao.ToString("C")} {Environment.NewLine}");
                    
            }
        }
    }
}