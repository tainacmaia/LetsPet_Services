using System;
using System.ComponentModel;

namespace LetsPet854.Domain.Common.Enuns
{
    public enum Species
    {
        [Description("Dog")]
        Cachorro = 1,
        [Description("Cat")]
        Gato = 2,
    }
}
