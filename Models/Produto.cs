using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardapioWeb.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Display(Name = "Nome do Produto")]
        [StringLength(100, ErrorMessage = "Limite de até {0} caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Display(Name = "Descrição Curta")]
        public string Descricao_curta { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Display(Name = "Descrição Detalhada")]
        public string Descricao_detalhada { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }


        [Display(Name = "Produto Preferido")]
        public bool Produto_preferido { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [Display(Name = "Em estoque")]
        public bool Em_estoque { get; set; }

        public virtual Categoria Categoria { get; set; }


    }
}
