using System;
using ZeroFormatter;

namespace HArCKtecture.Classes
{
    [ZeroFormattable]
    public class Operation
    {
        [Index(0)]
        public virtual uint Address { get; set; }

        [Index(1)]
        public virtual OperationType OperationType { get; set; }

        [Index(2)]
        public virtual string Value { get; set; }

        [Index(3)]
        public virtual TimeSpan ElapsedTime { get; set; }
    }
}
