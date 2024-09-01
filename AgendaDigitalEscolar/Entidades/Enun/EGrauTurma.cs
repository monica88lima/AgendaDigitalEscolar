using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Enun
{
    public enum EGrauTurma
    {
        [Description("Educação Infantil")]
        EducacaoInfantil = 1,

        [Description("Ensino Fundamental I")]
        EnsinoFundamentalI = 2,

        [Description("Ensino Fundamental II")]
        EnsinoFundamentalII = 3,

        [Description("Ensino Médio")]
        EnsinoMedio = 4

    }
}
