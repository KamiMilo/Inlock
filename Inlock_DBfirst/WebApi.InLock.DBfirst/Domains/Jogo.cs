using System;
using System.Collections.Generic;

namespace WebApi.InLock.DBfirst.Domains;

public partial class Jogo
{
    public Guid IdJogo { get; set; }

    public Guid? IdEstudio { get; set; }

    public string Nome { get; set; } = null!;

    public string? Descricao { get; set; }

    public DateTime DataLancamento { get; set; }

    public decimal Valor { get; set; }

    public virtual Estudio? IdEstudioNavigation { get; set; }
}
