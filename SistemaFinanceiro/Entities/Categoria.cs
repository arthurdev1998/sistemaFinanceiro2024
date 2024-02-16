using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaFinanceiro.Entities;

[Table("Categoria")]
public class Categoria : Base
{
    [ForeignKey("SistemaFinanceiro")]
    public int SistemaFinanceiroId { get; set; }

    public virtual SistemaFinanceiroo? SistemaFinanceiro { get; set; }
}