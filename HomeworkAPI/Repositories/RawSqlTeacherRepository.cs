using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkAPI.Domain;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace HomeworkAPI.Repositories
{
    public class RawSqlTeacherRepository: ITeacherRepository
    {
        private readonly string _connectionString;

        public RawSqlTeacherRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public List<Teacher> GetAll()
        {
            var result = new List<Teacher>();

            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            using SqlCommand sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = "select [Id], [TeachersName], [TaughtSubject] from [Teacher]";

            using SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Teacher(
                    Convert.ToInt32(reader["Id"]),
                    Convert.ToString(reader["TeachersName"]),
                    Convert.ToString(reader["TaughtSubject"])
                ));
            }

            return result;
        }

        public Teacher GetByName(string teachersName)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            using SqlCommand sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = "select [Id], [TeachersName], [TaughtSubject] from [Teacher] where [TeachersName] = @teachersName";
            sqlCommand.Parameters.Add("@teachersName", SqlDbType.NVarChar, 50).Value = teachersName;

            using SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                return new Teacher(
                    Convert.ToInt32(reader["Id"]),
                    Convert.ToString(reader["TeachersName"]),
                    Convert.ToString(reader["TaughtSubject"]));
            }
            else
            {
                return null;
            }
        }

        public void Delete(Teacher teachers)
        {
            if (teachers == null)
            {
                throw new ArgumentNullException(nameof(teachers));
            }

            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            using SqlCommand sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = "delete [Teacher] where [Id] = @id";
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = teachers.Id;
            sqlCommand.ExecuteNonQuery();
        }

        public List<Tuple<int,string>>GroupByTaughtSubject()
        {
            var result = new List<Tuple<int, string>>();

            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            using SqlCommand sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = "select count([Id]) c, [TaughtSubject] from [Teacher] group by [TaughtSubject]";

            using SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Tuple<int,string>(
                    Convert.ToInt32(reader["c"]),
                    Convert.ToString(reader["TaughtSubject"])
                ));
            }

            return result;
        }

        public void Update(Teacher teacher)
        {
            if (teacher == null)
            {
                throw new ArgumentNullException(nameof(teacher));
            }

            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            using SqlCommand sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = "update [Teacher] set [TeachersName] = @teachersName where [Id] = @id";
            using SqlCommand sqlCommand2 = connection.CreateCommand();
            sqlCommand.CommandText = "update [Teacher] set [TaughtSubject] = @taughtSubject where [Id] = @id";
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = teacher.Id;
            sqlCommand.Parameters.Add("@teachersName", SqlDbType.NVarChar,50).Value = teacher.TeachersName;
            sqlCommand.Parameters.Add("@taughtSubject", SqlDbType.NVarChar, 30).Value = teacher.TaughtSubject;
            sqlCommand.ExecuteNonQuery();
        }

        public void Create(Teacher teacher)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            using SqlCommand sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = "insert into [Teacher] (TeachersName, TaughtSubject) values (@teachersName, @taughtSubject)";
            sqlCommand.Parameters.Add("@teachersName", SqlDbType.NVarChar, 50).Value = teacher.TeachersName;
            sqlCommand.Parameters.Add("@taughtSubject", SqlDbType.NVarChar, 30).Value = teacher.TaughtSubject;
            sqlCommand.ExecuteNonQuery();
        }

        public Teacher GetById(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            using SqlCommand sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = "select [Id], [TeachersName], [TaughtSubject] from [Teacher] where [Id] = @id";
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;

            using SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                return new Teacher(
                    Convert.ToInt32(reader["Id"]),
                    Convert.ToString(reader["TeachersName"]),
                    Convert.ToString(reader["TaughtSubject"]));
            }
            else
            {
                return null;
            }
        }
    }
}
