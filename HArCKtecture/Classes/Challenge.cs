using HArCKtecture.Interfaces;
using System;
using System.Collections.Generic;

namespace HArCKtecture.Classes
{
    public class Challenge : IChallenge
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string FileLocation { get; set; }
        public bool Rebase { get; set; }
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
    }
}
