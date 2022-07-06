namespace OrcamentoApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"Bem-Vindo Ao Sistema Arancia!{Environment.NewLine}" +
                    $"O que vc deseja?{ Environment.NewLine}" +
                    $"1 - Fazer um orçamento{ Environment.NewLine}" +
                    $"2 - Saber a comissão de um funcionário{ Environment.NewLine}"+
                    $"3 - SAIR");

                //var resposta = int.Parse(Console.ReadLine());
                _= int.TryParse(Console.ReadLine(), out var resposta);

                OrcamentoService service = new();

                if (resposta == 1)
                {
                    service.CriaOrcamento();
                }
                else if (resposta == 2)
                {
                    service.ConsultaComissão();
                }
                if(resposta == 3)
                {
                    break;
                }               
            }
            Console.WriteLine("Obrigado, por usar nossos serviços!");
        }
    }
}
