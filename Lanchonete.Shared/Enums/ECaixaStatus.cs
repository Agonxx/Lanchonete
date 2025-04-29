using System.ComponentModel;

namespace Lanchonete.Shared.Enums
{
    public enum ECaixaStatus
    {
        [Description("Aberto")]
        Aberto = 1,

        [Description("Encerrado")]
        Encerrado = 2,
    }
}
