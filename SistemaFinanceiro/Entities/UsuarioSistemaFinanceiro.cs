using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaFinanceiro.Entities;

public class UsuarioSistemaFinanceiro
{
    public int Id { get; set; }
    public string? EmailUsuario { get; set; }
    public bool Administrador { get; set; }
    public bool SistemaAtual { get; set; }

    [ForeignKey("SistemaFinanceiro")]
    [Column(Order = 1)]
    public int SistemaFinanceiroId { get; set; }
    public virtual SistemaFinanceiroo? SistemaFinanceiro { get; set; }

}