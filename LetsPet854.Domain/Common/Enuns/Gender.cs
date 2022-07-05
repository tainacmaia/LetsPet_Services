using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace LetsPet854.Domain.Common.Enuns
{
    public enum Gender
    {
        [Description("Female")] 
        Fêmea = 1,
        [Description("Male")] 
        Macho
    }
}
