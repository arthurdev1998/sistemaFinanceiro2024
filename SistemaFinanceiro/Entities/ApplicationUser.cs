using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace SistemaFinanceiro.Entities;

public class ApplicationUser : IdentityUser
{
    [Column]
    public string? CPF { get; set; }
}