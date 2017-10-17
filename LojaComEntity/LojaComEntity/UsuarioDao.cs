using LojaComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComEntity
{
    class UsuarioDao
    {
        private EntidadesContext contexto;

        public UsuarioDao()
        {
            contexto = new EntidadesContext();
        }

        public void Salva(Usuario usuario)
        {
            contexto.Usuarios.Add(usuario);
            SaveChanges();
        }

        public Usuario BuscarPorId(int id)
        {
            return contexto.Usuarios.FirstOrDefault(u => u.ID == id);
        }

        public void Remove(Usuario usuario)
        {
            contexto.Usuarios.Remove(usuario);
            SaveChanges();
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }
    }
}
