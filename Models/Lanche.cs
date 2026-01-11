
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchoneteMVC.Models;

[Table("Lanches")]
public class Lanche
{
    public int LancheId { get; set; }
    [Required]
    [StringLength(80)]
    public string Nome { get; set; }
    [Required]
    [StringLength(200)]
    public string DescricaoCurta { get; set; }
    [Required]
    [StringLength(500)]
    public string DescricaoDetalhada { get; set; }
    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public decimal Preco { get; set; }
    [StringLength(200)]
    public string ImagemUrl { get; set; }
    [StringLength(200)]
    public string ImagemThumbnailUrl { get; set; }
    public bool IsLanchePreferido { get; set; }
    public bool EmEstoque { get; set; }
    public int CategoriaId { get; set; }
    public virtual Categoria Categoria { get; set; }
}
