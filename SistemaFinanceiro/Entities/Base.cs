using System.ComponentModel.DataAnnotations;
using SistemaFinanceiro.Notifications;

namespace SistemaFinanceiro.Entities;

public class Base : Notifica
{
    [Display(Name = "Código")]
    public int Id { get; set; }

    [Display(Name = "Nome")]
    public string? Nome { get; set; }
}