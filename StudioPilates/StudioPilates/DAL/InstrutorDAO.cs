using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudioPilates.Model;
namespace StudioPilates.DAL
{
    class InstrutorDAO
    {
        private static Context ctx = new Context();

        //add novo Instrutor
        public static bool AdicionarInstrutor(Instrutor i)
        {
            try
            {
                if (VerificaInstrutorPorCPF(i) == null) {
                    ctx.Instrutor.Add(i);
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

        //verifica se Instrutor ja existe
        public static Instrutor VerificaInstrutorPorCPF(Instrutor i)
        {
            return ctx.Instrutor.FirstOrDefault(x => x.CPF.Equals(i.CPF));
        }

        //busca lista de Instrutors
        public static List<Instrutor> ReturnLista()
        {
            return ctx.Instrutor.ToList();
        }

        //remove cadastro do Instrutor
        public static bool RemoverInstrutor(Instrutor i)
        {
            try
            {
                ctx.Instrutor.Remove(i);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //altera os dados do Instrutor
        public static bool AlterarInstrutor(Instrutor i)
        {
            try
            {
                ctx.Entry(i).State = System.Data.Entity.EntityState.Modified;
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
