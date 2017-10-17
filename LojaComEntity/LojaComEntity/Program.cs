using LojaComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Aula 01 
            EntidadesContext contexto = new EntidadesContext();

            Usuario renan = new Usuario()
            {
                Nome = "Renan",
                Senha = "123"
            };
            contexto.Usuarios.Add(renan);
            contexto.SaveChanges();
            contexto.Dispose();

            Console.WriteLine("Salvou o usuário.");
            Console.ReadLine();
            */
            /* Aula 02 */

            UsuarioDao dao = new UsuarioDao();

            /*Usuario vitor = new Usuario()
            {                
                Nome = "Vitor",
                Senha = "123"
            };

            dao.Salva(vitor);
            Console.WriteLine("Salvou o usuário.");

            vitor = dao.BuscarPorId(2);            
            dao.Remove(vitor);
            Console.WriteLine("Removeu o usuário.");
            */
            Usuario renan = dao.BuscarPorId(1);
            renan.Nome = "Renan Sarges";

            dao.SaveChanges();
            
            Console.ReadLine();
        }
    }
}
