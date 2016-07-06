using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudioPilates.Model
{

    [Table("Alunos")]
    class Aluno
    {
        [Key]
        public int AlunoId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public string DtNasc { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; }
        public string AvaliacaoFisica { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public int Plano { get; set; }

    }
}

