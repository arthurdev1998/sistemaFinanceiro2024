using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaFinanceiro.Notifications;

public class Notifica
{
    public Notifica()
    {
        Notificacoes = new List<Notifica>();
    }

    [NotMapped]
    public string? NomePropriedade { get; set; }

    [NotMapped]
    public string? Mensagem { get; set; }
    
    [NotMapped]
    public List<Notifica>? Notificacoes { get; set; }
}