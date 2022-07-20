using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkAPI.Domain;

namespace HomeworkAPI.Repositories
{
    public interface ITeacherRepository
    {
        List<Teacher> GetAll();
        Teacher GetByName(string name);
        Teacher GetById(int id);
        void Delete(Teacher teacher);
        IReadOnlyList<Teacher> GroupByTaughtSubject();
        void Create(Teacher teacher);
        void Update(Teacher teacher);
    }
}
