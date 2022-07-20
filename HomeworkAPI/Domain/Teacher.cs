namespace HomeworkAPI.Domain
{
    public class Teacher
    {
        public Teacher(int id, string teachersName, string taughtSubject)
        {
            Id = id;
            TeachersName = teachersName;
            TaughtSubject = taughtSubject;
        }

        public int Id { get; set; }
        public string TeachersName{ get; set; }
        public string TaughtSubject { get; set; }
    }
}
