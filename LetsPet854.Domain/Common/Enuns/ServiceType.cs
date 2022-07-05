using System.ComponentModel;

namespace LetsPet854.Domain.Common.Enuns
{
    public enum ServiceType
    {
        [Description("Bath")] 
        Banho = 1,
        [Description("Grooming")] 
        Tosa = 2,
    }
}
