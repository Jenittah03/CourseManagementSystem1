using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem1
{
    internal class CourseRepository
    {
        private string connectionString = "Server=JENITTAH;Database=CourseManagementSystem;Trusted_Connection=true;TrustServerCertificate=true;";

        public void AddCourse(string title, string duration, decimal price)
        {
            using(var connection=new SqlConnection(connectionString))
            {
                connection.Open();
                var command=connection.CreateCommand();
                command.CommandText = @"insert into Courses(Title,Duration,Price)values(@title,@duration,@price)";
                command.Parameters.AddWithValue("@title",title);
                command.Parameters.AddWithValue("@duration",duration);
                command.Parameters.AddWithValue("@price", price);
                command.ExecuteNonQuery();
                Console.WriteLine("Course added Successfuly");

            }
        }

        public void ReadCourse()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command=connection.CreateCommand();
                command.CommandText = @"select * from Courses";
               
                using(var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"CourseID:{reader.GetInt32(0)},Title{reader.GetString(1)},Duration:{reader.GetString(2)},Price:{reader.GetDecimal(3)}");
                    }
                }
            }

        }

        public void UpdateCourse(int CourseID, string title, string duration, decimal price)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"update Courses set Title=@newtitle,Duration=@newduration,Price=@newprice where CourseID=@courseid";
                command.Parameters.AddWithValue("@newtitle",title);
                command.Parameters.AddWithValue("@newduration",duration);
                command.Parameters.AddWithValue("@newprice", price);
                command.Parameters.AddWithValue("@courseid",CourseID);
                command.ExecuteNonQuery();

                Console.WriteLine("Course added Successfuly");

            }
        }

        public void RemoveCourse(int courseID)
        {
            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"delete from Courses where CourseId=@courseID";
                command.Parameters.AddWithValue("@courseID", courseID);
                command.ExecuteNonQuery ();
                Console.WriteLine("course deleted successfully");
            }
        }

        public string CapitalizeTitle(string title)
        {
            var words = title.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }

            return string.Join(" ", words);
        }

    
    }
}
