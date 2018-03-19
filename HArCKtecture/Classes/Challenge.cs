using System;
using System.Collections.Generic;
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
        public virtual byte[] ExecutableBytes { get; set; }

        [Index(3)]
        public virtual bool DynamicBase { get; set; }

        [Index(4)]
        public virtual ArchitectureMode Architecture { get; set; }

        [Index(5)]
        public virtual DificultyLevel Dificulty { get; set; }

        [Index(6)]
        public virtual IList<SpecialAddress> Addresses { get; set; }

        [Index(7)]
        public virtual long Order { get; set; }

        [Index(8)]
        public virtual uint AnswerAddress { get; set; }

        [Index(9)]
        public virtual bool Finished { get; set; }

        #region Reporting

        [Index(10)]
        public virtual TimeSpan TotalTime { get; set; }

        [Index(11)]
        public virtual uint MemoryOperations { get; set; }

        [Index(12)]
        public virtual uint RemoteProcessCrashes { get; set; }

        [Index(13)]
        public virtual bool Cheated { get; set; }

        #endregion

        public void Save()
        {
            File.WriteAllBytes(Globals.DIRECTORY_NAME + "//" + Name + ".hck", ZeroFormatterSerializer.Serialize(this));
        }
    }
}
