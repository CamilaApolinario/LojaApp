namespace OrcamentoApp
{
    public class OrcamentoService
    {
        private readonly IRestClient _restClient;

        public OrcamentoService()
        {
            _restClient = new RestClient();
        }

        public void CriaOrcamento()
        {
            Console.WriteLine("Qual o seu nome?");
            var name = Console.ReadLine();

            var currentDate = DateTime.Now;

            Console.WriteLine($"{Environment.NewLine}Olá, {name}, em {currentDate:d} às {currentDate:t}!");

            var resposta = true;
            while (resposta)
            {
                if (resposta == true)
                {
                    Console.WriteLine($"Qual desses produtos você deseja, {name}?");

                    _restClient.GetProdutoAsync().Wait();

                    var nomeProduto = Console.ReadLine();

                    Console.WriteLine("Digite a Quantidade:");
                    var quantidadeProduto = Int32.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Console.WriteLine("Deseja algo mais?");
                    var resposta2 = Console.ReadLine();

                    if (resposta2 == "sim")
                    {
                        return;
                    }

                    OrcamentoRequest orcamentoRequest = new(nomeProduto, quantidadeProduto);

                    _restClient.ExecutarOrcamentoAsync(orcamentoRequest).Wait();
                }
                resposta = false;

            }
        }

        public void ConsultaComissão()
        {
            RestClient client = new();

            Console.WriteLine("Você deseja consultar comissão de qual funcionário. Digite o id.");

            var id = int.Parse(Console.ReadLine());

            Console.WriteLine();

            client.ConsultaComissaoAsync(id).Wait();
        }
    }
}
