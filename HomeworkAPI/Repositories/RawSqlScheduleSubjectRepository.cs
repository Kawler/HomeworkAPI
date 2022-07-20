using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkAPI.Domain;
using System.Data;
using System.Data.SqlClient;

namespace HomeworkAPI.Repositories
{
    public class RawSqlScheduleSubjectRepository : IScheduleSubjectRepository
    {
        private readonly string _connectionString;

        public RawSqlScheduleSubjectRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<ScheduleSubject> GetAll()
        {
            var result = new List<ScheduleSubject>();

            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            using SqlCommand sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = "select [ScheduleSubjectId], [ScheduleId], [SubjectId] from [ScheduleSubject]";

            using SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new ScheduleSubject(
                    Convert.ToInt32(reader["ScheduleSubjectId"]),
                    Convert.ToInt32(reader["ScheduleId"]),
                    Convert.ToInt32(reader["SubjectId"])
                ));
            }

            return result;
        }
    }
}
