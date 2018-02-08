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

    public enum DataTypes
    {
        [Description("Inteiro")]
        INTEGER,
        [Description("Real")]
        FLOAT,
        [Description("Booleano/bit")]
        BIT,
        [Description("Caractere")]
        CHAR,
        [Description("Texto")]
        STRING,
        [Description("Byte")]
        BYTE
    }
}
