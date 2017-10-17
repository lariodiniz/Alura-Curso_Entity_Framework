using LojaComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComEntity
{
    class ProdutoDao
    {
        private EntidadesContext contexto;

        public ProdutoDao()
        {
            contexto = new EntidadesContext();
        }

        public void Salva(Produto produto)
        {
            contexto.Produtos.Add(produto);
            SaveChanges();
        }

        public Produto BuscarPorId(int id)
        {
            return contexto.Produtos.FirstOrDefault(p => p.ID == id);
        }

        public void Remove(Produto produto)
        {
            contexto.Produtos.Remove(produto);
            SaveChanges();
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }
    }
}
