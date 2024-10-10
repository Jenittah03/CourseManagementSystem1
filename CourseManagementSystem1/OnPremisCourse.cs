using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem1
{
    internal class OnPremisCourse:Course
    {

        public string Schedule {  get; set; }
        public int ClassroomCapacity { get; set; }

        public OnPremisCourse(int courseid, string title, string duration, decimal price,string schedule, int classroomCapacity):base(courseid, title, duration,price)    
        {
            Schedule = schedule;
            ClassroomCapacity = classroomCapacity;
        }

        public override string ToString()
        {
            return base.ToString() + $"Schedule:{Schedule},ClassroomCapacity:{ClassroomCapacity} ";
        }

        public override string DisplyCourseInfo()
        {
            return base.DisplyCourseInfo() + $"Schedule:{Schedule},ClassroomCapacity:{ClassroomCapacity} ";
        }

    }

   
}
