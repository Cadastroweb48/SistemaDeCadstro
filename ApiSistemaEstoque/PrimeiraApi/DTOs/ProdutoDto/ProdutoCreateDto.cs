namespace PrimeiraApi.DTOs.ProdutoDto
{
    public class ProdutoCreateDto
    {
        public string Nome {  get; set; } = string.Empty;
        public int Quantidade { get; set; }
        public string? Descricao { get; set; }
        public int? CategoriaId { get; set; }
    }
}
