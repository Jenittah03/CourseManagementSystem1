using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem1
{
    internal class DigitalCourse:Course
    {
       public string CourseLink {  get; set; }
        public int FileSize { get; set; }

        public DigitalCourse(int courseid, string title, string duration, decimal price, string courselink, int filesize):base(courseid,title,duration,price)
        {
            CourseLink = courselink;
            FileSize = filesize;
        }

        public override string ToString()
        {
            return base.ToString() + $"Link:{CourseLink}, FileSize:{FileSize}";

        }

        public override string DisplyCourseInfo()
        {
            return base.ToString() + $"Link:{CourseLink}, FileSize:{FileSize}";
        }

    }
}
