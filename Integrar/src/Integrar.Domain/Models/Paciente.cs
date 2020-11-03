using Integrar.Domain.Entities;
using Integrar.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrar.Domain.Models
{
    public class Paciente : EntityBase
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataInternacao { get; set; }
        public string Email { get; set; }
        public bool Internado { get; set; }
        public string CPF { get; set; }
        public PacienteTipo Tipo { get; set; }
        public Sexo Sexo { get; set; }
        public string Rg { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Nome}";
        }
    }
}
