using System;

namespace Integrar.Domain.Entities
{
    public class Mural
    {
        public int MuralID { get; set; }
        public DateTime Data { get; set; }
        public string Titulo { get; set; }
        public string Aviso { get; set; }
        public string Autor { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"ID:{MuralID} Titulo:{Titulo}";
        }
    }
}
