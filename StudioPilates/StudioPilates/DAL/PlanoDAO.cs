using StudioPilates.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioPilates.DAL
{
    class PlanoDAO
    {
        private static Context ctx = new Context();

        //add novo  Plano
        public static bool AdicionarPlano(Plano p)
        {
            try
            {
                //Não esquecer de chamar a Validação.
                if (VerificaPlanoPorNome(p) == null)
                {
                    ctx.Plano.Add(p);
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
        //verifica se o Plano ja existe
        public static Plano VerificaPlanoPorNome(Plano p)
        {
            return ctx.Plano.FirstOrDefault(x => x.Nome.Equals(p.Nome));
        }

        //busca lista de Planos
        public static List<Plano> ReturnLista()
        {
            try
            {
                return ctx.Plano.ToList();
            }
            catch
            {
                return null;
            }

        }

        //remove cadastro do Plano
        public static bool RemoverPlnao(Plano p)
        {
            try
            {
                ctx.Plano.Remove(p);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //altera os dados do aluno
        public static bool AlterarPlano(Plano p)
        {
            try
            {
                ctx.Entry(p).State = System.Data.Entity.EntityState.Modified;
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
