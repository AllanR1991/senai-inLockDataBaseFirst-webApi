using System;
using System.Collections.Generic;

namespace senai_inLockDataBaseFirst_webApi.Domains;

public partial class Jogo
{
    public int IdJogo { get; set; }

    public int IdEstudio { get; set; }

    public string NomeJogo { get; set; } = null!;

    //null! -> O operador null-forgiving é usado para suprimir todos os avisos nullable para a expressão precedente123. Ele não tem efeito em tempo de execução123. Ele só afeta a análise de fluxo estático do compilador, alterando o estado nulo da expressão
    public string Descricao { get; set; } = null!;

    public DateTime DataLancamento { get; set; }

    public decimal Valor { get; set; }

    public virtual Estudio IdEstudioNavigation { get; set; } = null!;
}
