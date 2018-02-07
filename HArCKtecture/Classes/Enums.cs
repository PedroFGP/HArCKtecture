using System.ComponentModel;

namespace HArCKtecture.Classes
{
    public enum DificultyLevel
    {
        [Description("Muito Fácil")]
        VERY_EASY = 1,
        [Description("Fácil")]
        EASY,
        [Description("Médio")]
        MEDIUM,
        [Description("Difícil")]
        HARD,
        [Description("Muito Difícil")]
        VERY_HARD
    }
}
