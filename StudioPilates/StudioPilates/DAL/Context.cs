using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudioPilates.Model;
using System.Data.Entity;

namespace StudioPilates.DAL
{
    class Context : DbContext
    {

        public DbSet<Aluno> Aluno { get; set; }

        public DbSet<Instrutor> Instrutor { get; set; }

        public DbSet<Plano> Plano { get; set; }

        public DbSet<Agenda> Agenda { get; set; }

        public DbSet<AlunoAgenda> AlunoAgenda { get; set; }

    }
}
