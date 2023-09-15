using System;
using System.Collections.Generic;

namespace WebApi.InLock.DBfirst.Domains;

public partial class Usuario
{
    public Guid Usuario1 { get; set; }

    public Guid? IdTipoUsuario { get; set; }

    public string Email { get; set; } = null!;

    public string Senha { get; set; } = null!;

    public virtual TipoUsuario? IdTipoUsuarioNavigation { get; set; }
}
