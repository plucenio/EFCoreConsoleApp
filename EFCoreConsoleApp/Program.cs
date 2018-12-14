
using EFCoreConsoleApp.Context;
using EFCoreConsoleApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Oi
            Console.WriteLine("Oi pessoal da Numeria!");
            Console.ReadLine();
            #endregion

            #region Introdução
            Console.WriteLine("Como já temos dados na tabela de Cidades vamos inserir dados na tabela Pessoas.");
            Console.ReadLine();
            #endregion

            #region Inserção
            List<Pessoa> pessoas = new List<Pessoa>
            {
                new Pessoa() { CidadeId = 1, AnoDeNascimento = 1987, Nome = "Filipe" },
                new Pessoa() { CidadeId = 2, AnoDeNascimento = 1980, Nome = "João" }
            };            
            using (var db = new BancoDeDadosContext())
            {
                db.Pessoas.AddRange(pessoas);
                db.SaveChanges();
            }
            #endregion

            #region Listagem
            Console.WriteLine("Listagem das pessoas no banco de dados:");
            using (var db = new BancoDeDadosContext())
            {
                pessoas = db.Pessoas.ToList();
            }
            foreach(var pessoa in pessoas)
            {
                pessoa.Idade = DateTime.Now.Year - pessoa.AnoDeNascimento;
                Console.WriteLine(pessoa);
            }
            Console.ReadLine();
            #endregion

            #region Filtragem
            Console.WriteLine("Filtragem das pessoas que moram em Torres:");
            using (var db = new BancoDeDadosContext())
            {
                pessoas = db.Pessoas.Where(p => p.CidadeId == 1).ToList();
            }
            foreach (var pessoa in pessoas)
            {
                pessoa.Idade = DateTime.Now.Year - pessoa.AnoDeNascimento;
                Console.WriteLine(pessoa);
            }
            Console.ReadLine();
            #endregion

            #region Join
            Console.WriteLine("Vamos fazer uma listagem com um JOIN entre Pessoas e Cidades.");
            using (var db = new BancoDeDadosContext())
            {
                var query = from p in db.Pessoas
                            join c in db.Cidades on p.CidadeId equals c.Id
                            select new { pessoa = p, cidade = c };

                foreach (var q in query)
                {
                    Console.WriteLine($"{q.pessoa.Nome.PadRight(20)} | {q.cidade.Nome}");
                }
            }
            Console.ReadLine();
            #endregion

            #region Consulta bruta SQL
            Console.WriteLine("Vamos fazer uma consulta bruta com SQL.");
            using (var db = new BancoDeDadosContext())
            {
                var listaPessoas = db.Pessoas
                                  .FromSql("SELECT p.Id, p.Nome, p.Nascimento_nome_alterado, p.CidadeId FROM dbo.Pessoas as p inner join dbo.Cidades as c on p.CidadeId = c.Id")
                                  .ToList();

                foreach (var p in listaPessoas)
                {
                    Console.WriteLine($"{p.Id.ToString("000")} | {p.Nome.PadRight(20)} | {p.AnoDeNascimento}");
                }
            }
            Console.ReadLine();
            #endregion

            #region Deleção
            Console.WriteLine("Ao final vamos deletar os registros da tabela Pessoas.");
            using (var db = new BancoDeDadosContext())
            {
                db.Pessoas.RemoveRange(db.Pessoas);
                db.SaveChanges();
            }
            Console.WriteLine("Todos as pessoas foram deletadas.");
            Console.ReadLine();
            #endregion
        }
    }
}
