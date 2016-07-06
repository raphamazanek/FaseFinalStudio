using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioPilates.Model
{
    [Table("Agenda")]
    class Agenda
    {
        public Agenda()
        {
        }

        [Key]
        public int AgendaId { get; set; }
        public string Aula { get; set; }
        public string DataInicio { get; set; }
        public string DataFinal { get; set; }
        public int Instrutor { get; set; }
    }
}
