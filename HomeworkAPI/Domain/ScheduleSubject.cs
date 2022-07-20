using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAPI.Domain
{
    public class ScheduleSubject
    {
        public ScheduleSubject(int id, int scheduleId, int subjectId)
        {
            Id = id;
            ScheduleId = scheduleId;
            SubjectId = subjectId;
        }

        public int Id { get; set; }
        public int ScheduleId { get; set; }
        public int SubjectId { get; set; }
    }
}
