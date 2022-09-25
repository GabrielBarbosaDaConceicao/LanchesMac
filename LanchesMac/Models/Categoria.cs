using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho máximo é de 100 caracteres.")]
        [Required(ErrorMessage = "Informe o nome da categoria.")]
        [DisplayName("Nome")]
        public string CategoriaNome { get; set; }

        [StringLength(200, ErrorMessage = "O tamanho máximo é de 100 caracteres.")]
        [Required(ErrorMessage = "Informe o a descrição da categoria.")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }
    }
}
