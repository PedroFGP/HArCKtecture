using ZeroFormatter;

namespace HArCKtecture.Classes
{
    [ZeroFormattable]
    public class SpecialAddress
    {
        [Index(0)]
        public virtual uint Address { get; set; }

        [Index(1)]
        public virtual string Description { get; set; }

        [Index(2)]
        public virtual AddressType Type { get; set; }

        [Index(3)]
        public virtual uint PairAddress { get; set; }
    }
}
