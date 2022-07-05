using System.ComponentModel;

namespace LetsPet854.Common.Domain
{
    public enum GroomingType
    {
        [Description("Hygienic")] 
        Higiênica = 1,
        [Description("Common")] 
        Comum = 2,
        [Description("Double")] 
        Dupla = 3,
    }
}
