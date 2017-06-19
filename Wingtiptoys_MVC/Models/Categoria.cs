using System.ComponentModel.DataAnnotations;

namespace BaseModels
{
    public class Categoria
    {
        [Key]
        public int CategoriaID { get; set; }
        [Required(ErrorMessage ="*"), StringLength(10,ErrorMessage ="Tamanho máximo de 10 cacteres")]
        public string Descricao { get; set; }
        [Display(Name ="Descricao"), DataType(DataType.MultilineText)]
        public string Nome { get; set; }
        [Required]
        public bool Ativo { get; set; }
    }
}
