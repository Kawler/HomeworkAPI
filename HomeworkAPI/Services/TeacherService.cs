using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkAPI.Domain;
using HomeworkAPI.Repositories;

namespace HomeworkAPI.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public void Create(Teacher teacher)
        {
            _teacherRepository.Create(teacher);
        }

        public void Delete(Teacher teacher)
        {
            _teacherRepository.Delete(teacher);
        }

        public List<Teacher> GetAll()
        {
            return (List<Teacher>)_teacherRepository.GetAll();
        }

        public Teacher GetById(int id)
        {
            return _teacherRepository.GetById(id);
        }

        public Teacher GetByName(string name)
        {
            return _teacherRepository.GetByName(name);
        }

        public IReadOnlyList<Teacher> GroupByTaughtSubject()
        {
            throw new NotImplementedException();
        }

        public void Update(Teacher teacher)
        {
            _teacherRepository.Update(teacher);
        }
    }
}
