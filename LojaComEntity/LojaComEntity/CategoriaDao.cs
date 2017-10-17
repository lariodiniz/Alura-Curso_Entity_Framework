using LojaComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComEntity
{
    class CategoriaDao
    {
        private EntidadesContext contexto;

        public CategoriaDao()
        {
            contexto = new EntidadesContext();
        }

        public void Salva(Categoria categoria)
        {
            contexto.Categorias.Add(categoria);
            SaveChanges();
        }

        public Categoria BuscarPorId(int id)
        {
            return contexto.Categorias.FirstOrDefault(c => c.ID == id);
        }

        public void Remove(Categoria categoria)
        {
            contexto.Categorias.Remove(categoria);
            SaveChanges();
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }
    }
}
