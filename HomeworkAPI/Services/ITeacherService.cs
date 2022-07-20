using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkAPI.Domain;

namespace HomeworkAPI.Services
{
    public interface ITeacherService
    {
        List<Teacher> GetAll();
        Teacher GetByName(string name);
        Teacher GetById(int id);
        void Delete(Teacher teacher);
        List<Teacher> GroupByTaughtSubject();
        void Create(Teacher teacher);
        void Update(Teacher teacher);
    }
}
