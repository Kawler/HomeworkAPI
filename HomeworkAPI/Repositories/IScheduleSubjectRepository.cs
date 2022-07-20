using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkAPI.Domain;

namespace HomeworkAPI.Repositories
{
    public interface IScheduleSubjectRepository
    {
        List<ScheduleSubject> GetAll();
    }
}
