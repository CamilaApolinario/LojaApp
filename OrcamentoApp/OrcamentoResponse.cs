namespace OrcamentoApp
{
    public class OrcamentoResponse
    {
        public int Id { get; set; }
        public double ComissaoVendedor { get; set; }
        public Vendedor? Vendedor { get; set; }
        public Produto? Produto { get; set; }
        public int Quatidade { get; set; }
        public double ValorTotal { get; set; }

    }
    public class Vendedor
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
    }
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public double Valor { get; set; }
    }
}
