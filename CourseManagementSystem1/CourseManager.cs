using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem1
{
    public class CourseManager
    {

        public List<Course> CourseList=new List<Course>();

        public CourseManager() { }

        public void createCourse(string Title,string Duration,decimal Price)
        {
            Course newcourse=new Course((CourseList.Count+1), Title, Duration, Price);  
            CourseList.Add(newcourse);
            Console.WriteLine("Course created successfully");
        }

        public void ReadCourse()
        {
            if (CourseList.Count > 0)
            {
                foreach (var course in CourseList)
                {
                    Console.WriteLine(course);
                }
            }
            else
            {
                Console.WriteLine("No Courses are available");
            }
        }

        public void UpdateCourse(int id,string Title,string Duration,decimal Price)
        {
            var course = CourseList.FirstOrDefault(c=>c.CourseID==id);
            if (course != null)
            {
                course.Title = Title;
                course.Duration = Duration;
                course.Price = Price;
                Console.WriteLine("Update Successfully");
            }
            else
            {
                Console.WriteLine("Course not found");
            }
        }

        public void Deletecourse(int id)
        {
            var course = CourseList.FirstOrDefault(c => c.CourseID == id);
            if (course != null)
            {
                CourseList.Remove(course);
                Console.WriteLine("Course remove successfully");
            }
            else
            {
                Console.WriteLine("Course not found");
            }
        }

        public decimal ValidateCoursePrice()
        {
            decimal price = 0;
            do
            {
                Console.WriteLine("Enter the course price");
                price = decimal.Parse(Console.ReadLine());

                if (price <= 0)
                {
                    Console.WriteLine("price must be positive");
                }

            } while (price <= 0);
            return price;


        }

    }
}
