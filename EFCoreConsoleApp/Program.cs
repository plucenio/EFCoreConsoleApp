
using EFCoreConsoleApp.Context;
using System;

namespace EFCoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oi pessoal da Numeria!");
            Console.ReadLine();
            Console.WriteLine("Como já temos dados na tabela de Cidades vamos inserir dados na tabela Pessoa!");
            Console.ReadLine();

            using (var db = new DataBaseContext())
            {
                db.Pessoas.Add(new Entities.Pessoa() { CidadeId = 1, AnoDeNascimento = 1987, Nome = "Filipe" });
                db.SaveChanges();
            }
            
        }
    }
}
