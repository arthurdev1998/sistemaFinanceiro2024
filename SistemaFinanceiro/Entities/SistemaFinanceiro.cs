using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaFinanceiro.Entities;

[Table("SistemaFinanceiro")]
public class SistemaFinanceiroo :Base
{
    public int Mes { get; set; }
    public int Ano { get; set; }
    public int DiaFechamento { get; set; }
    public bool GerarCopiaDespesa { get; set; }
    public int MesCopia { get; set; }
    public int AnoCopia { get; set; }
}