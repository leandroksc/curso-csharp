using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Integrar.Domain.Entities
{
    public class Produto
    {
        public Produto()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        [Display(Name = "ID do produto")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Descrição")]
        [StringLength(80, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Range(0, 4000, ErrorMessage = "O campo {0} deve ser entre {2} e {1}")]
        public Decimal Valor { get; set; } = 0;
        public int Estoque { get; set; } = 0;

        [Display(Name = "Data de Validade", Description = "Selecione uma data de validade")]
        [DataType(DataType.Date, ErrorMessage = "Data inválida")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Validade { get; set; }
        public bool Ativo { get; set; } = true;

    }
}
