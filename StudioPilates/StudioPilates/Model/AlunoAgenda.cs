using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioPilates.Model
{
    [Table("AlunoAgenda")]
    class AlunoAgenda
    {
        [Key]
        public int AlunoAgendaID { get; set; }
        public int Agenda { get; set; }
        public int Aluno { get; set; }
    }
}
