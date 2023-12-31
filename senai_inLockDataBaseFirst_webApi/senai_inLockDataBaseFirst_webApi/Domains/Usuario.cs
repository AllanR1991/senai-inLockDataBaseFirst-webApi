﻿using System;
using System.Collections.Generic;

namespace senai_inLockDataBaseFirst_webApi.Domains;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public int IdTipoUsuario { get; set; }

    public string Email { get; set; } = null!;

    public string Senha { get; set; } = null!;

    public virtual TipoUsuario IdTipoUsuarioNavigation { get; set; } = null!;
}
