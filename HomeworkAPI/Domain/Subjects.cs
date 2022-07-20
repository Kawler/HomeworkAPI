using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAPI.Domain
{
    public class Subjects
    {
        public Subjects(int id, int classroom, string subjectName)
        {
            Id = id;
            Classroom = classroom;
            SubjectName = subjectName;
        }

        public int Id { get; set; }
        public int Classroom { get; set; }
        public string SubjectName { get; set; } 
    }
}
