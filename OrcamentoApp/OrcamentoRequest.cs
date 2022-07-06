using System.Text.Json.Serialization;

namespace OrcamentoApp
{
    public class OrcamentoRequest
    {
        public OrcamentoRequest(string nomeProduto, int quantidadeProduto)
        {
            NomeProduto = nomeProduto;
            QuantidadeProduto = quantidadeProduto;
        }

        [JsonPropertyName("nomeProduto")]
        public string NomeProduto { get; set; }

        [JsonPropertyName("quantidadeProduto")]
        public int QuantidadeProduto { get; set; }
    }
}