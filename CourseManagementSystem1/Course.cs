using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem1
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public decimal Price { get;set; }
        public int TotalCourses { get; set; }

        public Course(int courseID, string title, string duration, decimal price)
        {
            CourseID = courseID;
            Title = title;
            Duration = duration;
            Price = price;
            TotalCourses++;
        }

        public override string ToString() 
        {
            return $"ID:{CourseID},Tilte:{Title},Duration:{Duration},Price:{Price}";
        }

        public virtual string DisplyCourseInfo()
        {
            return $"ID:{CourseID},Tilte:{Title},Duration:{Duration},Price:{Price}";
        }
    }
}
