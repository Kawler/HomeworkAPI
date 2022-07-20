using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkAPI.Domain;

namespace HomeworkAPI.Repositories
{
    public interface ISubjectsRepository
    {
        List<Subjects> GetAll();
        Subjects GetById(int id);
        Subjects GetByName(string name);
        void Update(Subjects subjects);
        void Delete(Subjects subjects);
        void Create(Subjects subjects);
        List<Teacher> GroupByTaughtSubject();
    }
}
