using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alunos.Model;
using Alunos.Controller;
namespace Alunos.Controller
{
    public class AlunoController
    {
        EntityContextDB contextDb = new EntityContextDB();
        public IQueryable<Aluno> GetAlunos()
        {
            return contextDb.listaDeAlunos;
        }
        public void AddAluno(Aluno item)
        {
            contextDb.listaDeAlunos.Add(item);
            contextDb.SaveChanges();
        }
    }
}
