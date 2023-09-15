using System;
using System.Collections.Generic;

namespace WebApi.InLock.DBfirst.Domains;

public partial class Estudio
{
    public Guid IdEstudio { get; set; } = Guid.NewGuid();

    public string? Nome { get; set; }

    public virtual ICollection<Jogo> Jogos { get; set; } = new List<Jogo>();
}
