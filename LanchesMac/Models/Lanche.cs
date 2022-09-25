using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = "O nome do lanche deve ser informado.")]
        [DisplayName("Nome do Lanche")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição do lanche deve ser informada.")]
        [DisplayName("Descrição do Lanche")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caraceres.")]
        [MaxLength(200, ErrorMessage = "Descrição não pode exeder {1} caracteres.")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "A descrição detalhada deve ser informada.")]
        [DisplayName("Descrição detalhada")]
        [MinLength(20, ErrorMessage = "Descrição detalhada deve ter no mínimo {1} caraceres.")]
        [MaxLength(200, ErrorMessage = "Descrição detalhada não pode exeder {1} caracteres.")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Informe o preço do lanche.")]
        [DisplayName("Preco")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1,999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }

        [DisplayName("Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres.")]
        public string ImagemUrl { get; set; }

        [DisplayName("Caminho Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres.")]
        public string ImagemThumbnailUrl { get; set; }

        [DisplayName("Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [DisplayName("Estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
