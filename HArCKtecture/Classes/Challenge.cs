using HArCKtecture.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HArCKtecture.Classes
{
    public class Challenge : IChallenge, ISerializable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string FileLocation { get; set; }
        public bool DynamicBase { get; set; }
        public DificultyLevel Dificulty { get; set; }
        public IntPtr BaseAddress { get; set; }
        public Dictionary<string, IntPtr> Addresses;

        public Challenge()
        {
            Addresses = new Dictionary<string, IntPtr>();
        }

        public void Run()
        {

        }

        public string ShowHelp()
        {
            return Description;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
