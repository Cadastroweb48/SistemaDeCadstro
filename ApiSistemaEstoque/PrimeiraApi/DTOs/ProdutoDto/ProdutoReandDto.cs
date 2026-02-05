using PrimeiraApi.Models;

namespace PrimeiraApi.DTOs.ProdutoDto
{
    public class ProdutoReandDto
    {
		public int Id { get; set; }
		public string Nome { get; set; } = string.Empty;
		public int Quantidade { get; set; }
		public string? Descricao { get; set; }
		public int? CategoriaId { get; set; }
		public Categoria? Categoria { get; set; }

	}
}
