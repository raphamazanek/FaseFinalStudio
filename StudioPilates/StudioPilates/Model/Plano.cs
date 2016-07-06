using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioPilates.Model
{
    [Table("Plano")]
    class Plano
    {
        [Key]
        public int PlanoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
