using System.ComponentModel;

namespace Entidades.Enun
{
    public enum EHigieneStatus
    {

        [Description("Higienizado")]
        Higienizado = 1,

        [Description("Não Higienizado")]
        NHigienizado = 2,

        [Description("Não se Aplica")]
        Nenhuma = 3

       

        
    }
}
