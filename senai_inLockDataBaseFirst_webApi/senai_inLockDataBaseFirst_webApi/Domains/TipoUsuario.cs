using System;
using System.Collections.Generic;

namespace senai_inLockDataBaseFirst_webApi.Domains;

public partial class TipoUsuario
{
    public int IdTipoUsuario { get; set; }

    public string Titulo { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
