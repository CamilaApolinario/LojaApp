namespace OrcamentoApp
{
    public interface IRestClient
    {
        Task GetProdutoAsync();

        Task ExecutarOrcamentoAsync(OrcamentoRequest orcamentoRequest);
    }
}