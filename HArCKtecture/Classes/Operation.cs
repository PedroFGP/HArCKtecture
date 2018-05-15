using MessagePack;
using System;

namespace HArCKtecture.Classes
{
    [MessagePackObject]
    public class Operation
    {
        [Key(0)]
        public virtual uint Address { get; set; }

        [Key(1)]
        public virtual OperationType OperationType { get; set; }

        [Key(2)]
        public virtual string Value { get; set; }

        [Key(3)]
        public virtual TimeSpan ElapsedTime { get; set; }

        [Key(4)]
        public virtual DataType InterpretedType { get; set; }
    }
}
