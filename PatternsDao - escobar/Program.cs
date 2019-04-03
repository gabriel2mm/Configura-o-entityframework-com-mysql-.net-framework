using PatternsDao___escobar.Models;
using PatternsDao___escobar.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDao___escobar
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunosRepository dao = new AlunosRepository();
            EntityAluno al = new EntityAluno();

            al.Nome = "Gabriel";
            al.Sobrenome = "Moré";
            al.Ativo = false;

            Console.WriteLine("Iniciando...");
            dao.Adicionar(al);
            dao.SalvarTodos();
            Console.WriteLine("Dados Salvos");
            Console.WriteLine("Resultado: ");
            IQueryable<EntityAluno> alunos = dao.GetAll();


            List<EntityAluno> result = alunos.Select(dados => dados).ToList();
            foreach(var r in result)
            {
                Console.WriteLine(r.Nome);
                Console.WriteLine("-----------");
            }
            Console.WriteLine("Numero de registros inseridos: " + alunos.Count());
            Console.ReadKey();
        }
    }
}
