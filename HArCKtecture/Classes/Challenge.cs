using System;
using System.IO;
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
        public virtual ILazyDictionary<string, uint> Addresses { get; set; }

        [Index(7)]
        public virtual long Order { get; set; }

        [Index(8)]
        public virtual uint AnswerAddress { get; set; }

        [Index(9)]
        public virtual bool Finished { get; set; }

        public void Save()
        {
            File.WriteAllBytes(Globals.DIRECTORY_NAME + "//" + Path.GetFileName(FileLocation).Replace(".exe", ".hck"), ZeroFormatterSerializer.Serialize(this));
        }
    }
}
