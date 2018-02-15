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

    public enum ArchitectureMode
    {
        x86_16 = 16,
        x86_32 = 32,
        x86_64 = 64
    }
}
