using System;
using System.Collections.Generic;

namespace senai_inLockDataBaseFirst_webApi.Domains;

public partial class Estudio
{
    public int IdEstudio { get; set; }

    public string NomeEstudio { get; set; } = null!;

    public virtual ICollection<Jogo> Jogos { get; set; } = new List<Jogo>();
}
