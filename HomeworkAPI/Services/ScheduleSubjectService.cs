using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkAPI.Domain;

namespace HomeworkAPI.Services
{
    public class ScheduleSubjectService : IScheduleSubject
    {
        private readonly IScheduleSubject _scheduleSubjectRepository;
        public ScheduleSubjectService(IScheduleSubject scheduleSubjectRepository)
        {
            _scheduleSubjectRepository = scheduleSubjectRepository;
        }
        public List<ScheduleSubjectService> GetAll()
        {
            return (List<ScheduleSubjectService>)_scheduleSubjectRepository.GetAll();
        }
    }
}
