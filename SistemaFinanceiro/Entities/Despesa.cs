using System.ComponentModel.DataAnnotations.Schema;
using SistemaFinanceiro.Entities.Enums;

namespace SistemaFinanceiro.Entities;

[Table("Despesa")]
public class Despesa
{
    public int Valor { get; set; }
    public int Mes { get; set; }
    public int Ano { get; set; }
    public DespesaEnum TipoDespesa { get; set; }
    public DateTime DataCadastro { get; set; }
    public DateTime DataAlteracao { get; set; }
    public DateTime DataPagamento { get; set; }
    public DateTime DataVencimento { get; set; }
    public bool Pago { get; set; }
    public bool DespesaAtrasada { get; set; }

    [ForeignKey("Categoria")]
    public int CategoriaId { get; set; }
    public virtual Categoria? Categoria { get; set; }
}