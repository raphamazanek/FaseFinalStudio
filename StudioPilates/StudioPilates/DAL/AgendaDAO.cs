using StudioPilates.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioPilates.DAL
{
    class AgendaDAO
    {

        private static Context ctx = new Context();

        public static bool AdicionarAgenda(Agenda a)
        {
            try
            {
                //Não esquecer de chamar a Validação.
                if (VerificaAgendaPorData(a) == null)
                {
                    ctx.Agenda.Add(a);
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
        public static Agenda VerificaAgendaPorData(Agenda a)
        {
            return ctx.Agenda.FirstOrDefault(x => x.DataInicio.Equals(a.DataInicio));
        }

        public static Agenda VerificaAgendaPorNome(Agenda a)
        {
            return ctx.Agenda.FirstOrDefault(x => x.Aula.Equals(a.Aula));
        }

        //busca lista de alunos
        public static List<Agenda> ReturnLista()
        {
            return ctx.Agenda.ToList();
        }

        //remove cadastro do aluno
        public static bool RemoverAgenda(Agenda a)
        {
            try
            {
                ctx.Agenda.Remove(a);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //altera os dados do aluno
        public static bool AlterarAgenda(Agenda a)
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
