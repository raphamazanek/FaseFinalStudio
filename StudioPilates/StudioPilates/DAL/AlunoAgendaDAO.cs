using StudioPilates.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioPilates.DAL
{
    class AlunoAgendaDAO
    {
        private static Context ctx = new Context();

        //add novo aluno
        public static bool AdicionarAlunoAgenda(AlunoAgenda a)
        {
            try
            {
                if (VerificaAlunoAgenda(a) == null)
                {
                    ctx.AlunoAgenda.Add(a);
                    ctx.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;

            }

        }

        //verifica se aluno ja existe
        public static AlunoAgenda VerificaAlunoAgenda(AlunoAgenda a)
        {
            return ctx.AlunoAgenda.FirstOrDefault(x => x.Aluno.Equals(a.Aluno) && x.Agenda.Equals(a.Agenda));
        }

        //busca lista de alunos
        public static List<AlunoAgenda> ReturnLista()
        {
                return ctx.AlunoAgenda.ToList();                     
        }

        //remove cadastro do aluno
        public static bool RemoverAlunoAgenda(AlunoAgenda a)
        {
            try
            {
                ctx.AlunoAgenda.Remove(a);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //altera os dados do aluno
        public static bool AlterarAlunoAgenda(AlunoAgenda a)
        {
            try
            {
                ctx.Entry(a).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

    }
}
