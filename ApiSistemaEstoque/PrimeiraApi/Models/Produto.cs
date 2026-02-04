using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeiraApi.Models
{
    public class Produto
    {
        [Key]
        public int Pd_Id { get; set; }
        public string Pd_Nome { get; set; } = string.Empty;
        public int Pd_Quantidade { get; set; }
        public string? Pd_Descricao { get; set; } = string.Empty;

        public int? Pd_Categoria {  get; set; }

		[ForeignKey("Pd_Categoria")]
		public Categoria? Categoria { get; set; }

	}
}
