﻿using LojaComEntity.Entidades;
using Microsoft.Data.Entity;
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
            /* Aula 02 

            UsuarioDao dao = new UsuarioDao();

            Usuario vitor = new Usuario()
            {                
                Nome = "Vitor",
                Senha = "123"
            };

            dao.Salva(vitor);
            Console.WriteLine("Salvou o usuário.");

            vitor = dao.BuscarPorId(2);            
            dao.Remove(vitor);
            Console.WriteLine("Removeu o usuário.");
           
            Usuario renan = dao.BuscarPorId(1);
            renan.Nome = "Renan Sarges";

            dao.SaveChanges();
            */

            /* Aula 03 

            EntidadesContext contexto = new EntidadesContext();

            /*  Categoria c = new Categoria()
              {
                  Nome = "Informática",
              };

              contexto.Categorias.Add(c);
              contexto.SaveChanges();


              Produto p = new Produto()
              {
                  Nome = "Mouse",
                  Preco = 20,
                  Categoria = c
              };*/

            /*
            Produto p = new Produto()
            {
                Nome = "Teclado",
                Preco = 30,
                CategoriaID = 1
                contexto.Produtos.Add(p);
                contexto.SaveChanges();
            };*/

            /*Produto p = contexto.Produtos.Include(produto => produto.Categoria).FirstOrDefault(produto => produto.ID == 1);
            Console.WriteLine("Nome do produto {0}", p.Categoria.Nome);

            var categoria = contexto.Categorias.Include(c => c.Produtos).FirstOrDefault(c => c.ID == 1);

            foreach(var p in categoria.Produtos)
            {
                Console.WriteLine("Nome do produto {0}", p.Nome);
            }

            Console.ReadLine();
            */

            /* Aula 04 

            CategoriaDao daoCategoria = new CategoriaDao();

            Categoria ca = new Categoria()
            {
                Nome = "Roupas"
                
            };

            daoCategoria.Salva(ca);
            Console.WriteLine("Salvou a categoria.");

            ProdutoDao daoProduto = new ProdutoDao();

            List<Produto> produtos = new List<Produto>();

            produtos.Add(new Produto()
                            {
                            Nome = "agasalho",
                            Preco = 50,
                            Categoria = ca
                            }                
                        );

            produtos.Add(new Produto()
                            {
                            Nome = "Camisa",
                            Preco = 25,
                            Categoria = ca
                            }
                        );

            produtos.Add(new Produto()
                            {
                            Nome = "Moleton",
                            Preco = 150,
                            Categoria = ca
                            }
                        );

            foreach (Produto item in produtos)
            {
                daoProduto.Salva(item);
                Console.WriteLine("Salvou um item.");
            }
            

            EntidadesContext contexto = new EntidadesContext();

            decimal precoMinimo = 40;

            var busca = from p in contexto.Produtos
                        where p.Categoria.Nome == "Roupas" && p.Preco > precoMinimo
                        orderby p.Preco
                        select p;

            IList<Produto> resultado = busca.ToList();
            
            foreach (var produto in resultado)
            {
                Console.WriteLine(produto.Nome+" - "+ produto.Preco);
            }

            Console.ReadLine();
            */

            /* Aula 05  

            EntidadesContext contexto = new EntidadesContext();

            ProdutoDao dao = new ProdutoDao();

            var resultado = dao.BuscaPorNomePrecoNome(null, 20, "informatica");

            foreach (var p in resultado)
            {
                Console.WriteLine(p.Nome);
            }
            Console.ReadLine();
            */

            /* Aula 06  
            EntidadesContext contexto = new EntidadesContext();

            UsuarioDao dao = new UsuarioDao();
            Usuario renan = dao.BuscarPorId(1);

            Venda v = new Venda()
            {
                Cliente = renan
            };

            Produto p = new ProdutoDao().BuscarPorId(1);
            Produto p2 = new ProdutoDao().BuscarPorId(2);

            ProdutoVenda pv = new ProdutoVenda()
            {
                Venda = v,
                Produto = p
            };


            ProdutoVenda pv2 = new ProdutoVenda()
            {
                Venda = v,
                Produto = p2
            };
            contexto.ProdutoVenda.Add(pv);
            contexto.ProdutoVenda.Add(pv2);

            contexto.Vendas.Add(v);

            contexto.SaveChanges();    

            Venda venda = contexto.Vendas.Include(v => v.ProdutoVenda).ThenInclude(pv => pv.Produto).FirstOrDefault(v => v.ID == 1);

            foreach (var pv in venda.ProdutoVenda)
            {
                Console.WriteLine(pv.Produto.Nome);
            }

            Console.ReadLine();

            */

            /* Aula 07  */
            EntidadesContext contexto = new EntidadesContext();

            PessoaFisica pf = new PessoaFisica()
            {
                Nome = "Guilherme",
                CPF = "123456",
                Senha = "123"
            };

            contexto.PessoasFisica.Add(pf);


            PessoaJuridica pj = new PessoaJuridica()
            {
                Nome = "Alura",
                CNPJ = "789",
                Senha = "132"
            };

            contexto.PessoasJuridica.Add(pj);

            Console.ReadLine();

        }
    }
}
