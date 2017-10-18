﻿using LojaComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComEntity
{
    public class ProdutoDao
    {
        private EntidadesContext contexto;

        public ProdutoDao()
        {
            contexto = new EntidadesContext();
        }

        public IList<Produto> BuscaPorNomePrecoNome(string nome, decimal preco, string nomeCategoria)
        {
            var busca = from p in contexto.Produtos
                        select p;

            if (!String.IsNullOrEmpty(nome))
            {
                busca = busca.Where(p => p.Nome == nome);
            }

            if (preco > 0.0m)
            {
                busca = busca.Where(p => p.Preco == preco);
            }

            if (!String.IsNullOrEmpty(nomeCategoria))
            {
                busca = busca.Where(p => p.Categoria.Nome == nomeCategoria);
            }

            return busca.ToList();
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
