
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchoneteMVC.Models;

[Table("Categorias")]
public class Categoria
{
    public int CategoriaId { get; set; }
    [Required(ErrorMessage = "O nome da categoria é obrigatório")]
    [StringLength(100, ErrorMessage = "O nome da categoria deve ter no máximo 100 caracteres")]
    public string CategoriaNome { get; set; }
    [Required(ErrorMessage = "A descrição é obrigatória")]
    [StringLength(200, ErrorMessage = "A descrição deve ter no máximo 200 caracteres")]
    public string Descricao { get; set; }
    public List<Lanche> Lanches { get; set; }
}
