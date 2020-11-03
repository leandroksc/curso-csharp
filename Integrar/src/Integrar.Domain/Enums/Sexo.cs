using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Integrar.Domain.Enums
{
    public enum Sexo
    {
        [Display(Name = "Fem")]
        Feminino = 1,

        [Display(Name = "Masc")]
        Masculino
    }
}
