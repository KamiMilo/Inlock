using System;
using System.Collections.Generic;

namespace WebApi.InLock.DBfirst.Domains;

public partial class TipoUsuario
{
    public Guid IdTipoUsuario { get; set; }

    public string Titulo { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
