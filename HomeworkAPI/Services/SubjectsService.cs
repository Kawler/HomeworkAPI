using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkAPI.Domain;
using HomeworkAPI.Repositories;

namespace HomeworkAPI.Services
{
    public class SubjectsService : ISubjectsService
    {
        private readonly ISubjectsRepository _subjectsRepository;
        public SubjectsService(ISubjectsRepository subjectsRepository)
        {
            _subjectsRepository = subjectsRepository;
        }

        public void Create(Subjects subjects)
        {
            _subjectsRepository.Create(subjects);
        }

        public void Delete(Subjects subjects)
        {
            _subjectsRepository.Delete(subjects);
        }

        public List<Subjects> GetAll()
        {
            return (List<Subjects>)_subjectsRepository.GetAll();
        }

        public Subjects GetById(int id)
        {
            return _subjectsRepository.GetById(id);
        }

        public Subjects GetByName(string name)
        {
            return _subjectsRepository.GetByName(name);
        }

        public List<Tuple<int, string>> GroupByTaughtSubject()
        {
            return _subjectsRepository.GroupByTaughtSubject();
        }

        public void Update(Subjects subjects)
        {
            _subjectsRepository.Update(subjects);
        }

    }
}
