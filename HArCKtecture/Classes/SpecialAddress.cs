using MessagePack;

namespace HArCKtecture.Classes
{
    [MessagePackObject]
    public class SpecialAddress
    {
        [Key(0)]
        public virtual uint Address { get; set; }

        [Key(1)]
        public virtual string Description { get; set; }

        [Key(2)]
        public virtual AddressType Type { get; set; }

        [Key(3)]
        public virtual uint PairAddress { get; set; }
    }
}
