namespace OrcamentoApp.Model
{
    public class Modelos
    {
        public class Produto
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public double Valor { get; set; }
        }

        public class Orcamento
        {
            public int Id { get; set; }
            public double ComissaoVendedor { get; set; }
            public Vendedor Vendedor { get; set; }
            public Produto Produto { get; set; }
        }

        public class Vendedor
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }


    }
}
