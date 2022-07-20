using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkAPI.Domain;

namespace HomeworkAPI.Services
{
    public interface ISubjectsService
    {
        List<Subjects> GetAll();
        Subjects GetById(int id);
        Subjects GetByName(string name);
        void Update(Subjects subjects);
        void Delete(Subjects subjects);
        void Create(Subjects subjects);
        List<Tuple<int, string>> GroupByTaughtSubject();
    }
}
