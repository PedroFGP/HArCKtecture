using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace HArCKtecture.Classes
{
    public enum DificultyLevel
    {
        [DescriptionList("Básico", "#29C5FF")]
        VERY_EASY = 1,
        [DescriptionList("Fundamental", "#51F5EA")]
        EASY,
        [DescriptionList("Intermediário", "#5EFCA1")]
        MEDIUM,
        [DescriptionList("Avançado", "#FFCF4B")]
        HARD,
        [DescriptionList("Expert", "#FFAC9C")]
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

    public enum OperationType
    {
        READ,
        WRITE,
        ASM_OVERWRITE
    }
}
