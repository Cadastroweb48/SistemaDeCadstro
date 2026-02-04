using System.ComponentModel.DataAnnotations;

namespace PrimeiraApi.Models
{
    public class Categoria
    {
        [Key]
        public int Cat_Id { get; set; }
        [Required]
        public string Cat_Nome {  get; set; } = string.Empty;
       

        public int? Cat_PaiId { get; set; }


        public Categoria? CategoriaPai { get; set; }

        public ICollection<Categoria> SubCategoria { get; set; }

    }
}
