namespace PrimeiraApi.DTOs.ProdutoDto
{
    public class ProdutoCreateDto
    {
		public string Pd_Nome { get; set; } = string.Empty;
		public int Pd_Quantidade { get; set; }
		public string? Pd_Descricao { get; set; }
		public string? Pd_ImagenUrl { get; set; }
		public int? Pd_Preco { get; set; }

		
		public int CategoriaId { get; set; }
	}
}
