using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudioPilates.Model;
namespace StudioPilates.DAL
{
    class AlunoDAO
    {
        private static Context ctx = new Context();
        
        public static bool AdicionarAluno(Aluno a)
        {
            try
            {
                if (VerificaAlunoPorCPF(a) == null)
                {
                    ctx.Aluno.Add(a);
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
        
        public static Aluno VerificaAlunoPorCPF(Aluno a)
        {
            return ctx.Aluno.FirstOrDefault(x => x.CPF.Equals(a.CPF));
        }

        public static List<Aluno> ReturnLista()
        {
            return ctx.Aluno.ToList();
        }

        //remove cadastro do aluno
        public static bool RemoverAluno (Aluno a)
        {
            try
            {
                ctx.Aluno.Remove(a);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //altera os dados do aluno
        public static bool AlterarAluno (Aluno a)
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
