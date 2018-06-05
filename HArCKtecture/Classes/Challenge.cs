using MessagePack;
using System;
using System.Collections.Generic;
using System.IO;

namespace HArCKtecture.Classes
{
    [MessagePackObject]
    public class Challenge
    {
        [Key(0)]
        public virtual string Name { get; set; }

        [Key(1)]
        public virtual string Description { get; set; }

        [Key(2)]
        public virtual byte[] ExecutableBytes { get; set; }

        [Key(3)]
        public virtual bool DynamicBase { get; set; }

        [Key(4)]
        public virtual ArchitectureMode Architecture { get; set; }

        [Key(5)]
        public virtual DificultyLevel Dificulty { get; set; }

        [Key(6)]
        public virtual List<SpecialAddress> Addresses { get; set; }

        [Key(7)]
        public virtual long Order { get; set; }

        [Key(8)]
        public virtual uint AnswerAddress { get; set; }

        [Key(9)]
        public virtual bool Finished { get; set; }

        #region Reporting

        [Key(10)]
        public virtual TimeSpan TotalTime { get; set; }

        [Key(11)]
        public virtual uint RemoteProcessCrashes { get; set; }

        [Key(12)]
        public virtual bool Cheated { get; set; }

        [Key(13)]
        public virtual List<Operation> Operations { get; set; }

        [Key(14)]
        public virtual uint BaseAddress { get; set; }

        #endregion

        public void Save()
        {
            File.WriteAllBytes(Globals.DIRECTORY_NAME + "//" + Name + ".hck", MessagePackSerializer.Serialize(this));
        }
    }
}
