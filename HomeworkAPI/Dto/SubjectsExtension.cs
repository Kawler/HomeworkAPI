using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkAPI.Domain;

namespace HomeworkAPI.Dto
{
    public static class SubjectsExtension
    {
        public static SubjectsDto ConvertToSubjectsDto(this Subjects subjects)
        {
            return new SubjectsDto
            {
               Id = subjects.Id,
               Classroom = subjects.Classroom,
               SubjectName = subjects.SubjectName
            };
        }
    }
}
