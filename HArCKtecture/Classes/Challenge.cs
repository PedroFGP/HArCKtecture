using System;
using ZeroFormatter;

namespace HArCKtecture.Classes
{
    [ZeroFormattable]
    public class Challenge
    {
        [Index(0)]
        public virtual string Name { get; set; }

        [Index(1)]
        public virtual string Description { get; set; }

        [Index(2)]
        public virtual string FileLocation { get; set; }

        [Index(3)]
        public virtual bool DynamicBase { get; set; }

        [Index(4)]
        public virtual ArchitectureMode Architecture { get; set; }

        [Index(5)]
        public virtual DificultyLevel Dificulty { get; set; }

        [Index(6)]
        public virtual uint BaseAddress { get; set; }

        [Index(7)]
        public virtual ILazyDictionary<string, uint> Addresses { get; set; }
    }
}
