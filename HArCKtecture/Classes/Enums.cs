using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace HArCKtecture.Classes
{
    public enum DificultyLevel
    {
        [DescriptionList("Muito Fácil", "#29C5FF")]
        VERY_EASY = 1,
        [DescriptionList("Fácil", "#51F5EA")]
        EASY,
        [DescriptionList("Médio", "#5EFCA1")]
        MEDIUM,
        [DescriptionList("Difícil", "#FFCF4B")]
        HARD,
        [DescriptionList("Muito Difícil", "#FFAC9C")]
        VERY_HARD
    }

    public enum DataType
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
        [Description("16 bit")]
        x86_16 = 16,

        [Description("32 bit")]
        x86_32 = 32,

        [Description("64 bit")]
        x86_64 = 64
    }

    public enum AddressType
    {
        NONE,
        START,
        END,
        SINGLE
    }
}
