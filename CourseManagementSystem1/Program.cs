using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var manager=new CourseManager();
            var Crepo=new CourseRepository();
            bool exit = false;
            while (!exit)
            {

                Console.WriteLine("Course Management System");
                Console.WriteLine("1.Add a Course");
                Console.WriteLine("2.View all Courses");
                Console.WriteLine("3.Update a course");
                Console.WriteLine("4.Delete a course");
                Console.WriteLine("5.Exit");
                Console.Write("Choose an option: ");
                int option = int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                        Console.Clear();

                        Console.WriteLine("Enter the Course title");
                        string title=Console.ReadLine();
                        Console.WriteLine("Enter the Course duration");
                        string duration=Console.ReadLine();
                        //Console.WriteLine("Enter the course price");
                        //decimal price=decimal.Parse(Console.ReadLine());

                        decimal price=manager.ValidateCoursePrice();
                        //manager.createCourse(title,duration,price);
                        Crepo.AddCourse(title, duration, price);

                        break;

                    case 2:
                        //manager.ReadCourse();
                        Crepo.ReadCourse();
                        break;

                    case 3:
                        Console.Clear();

                        Console.WriteLine("Enter the course id");
                        int id =int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the Course title");
                        string newtitle = Console.ReadLine();
                        Console.WriteLine("Enter the Course duration");
                        string newduration = Console.ReadLine();
                        Console.WriteLine("Enter the course price");
                        decimal newprice = decimal.Parse(Console.ReadLine());

                        
                        //manager.UpdateCourse(id,newtitle,newduration,newprice); 
                        Crepo.UpdateCourse(id, newtitle, newduration, newprice);
                        break;

                    case 4:

                        Console.Clear();
                        Console.WriteLine("Enter the coursrid to delete");
                        int deletedid=int.Parse(Console.ReadLine());

                        //manager.Deletecourse(deletedid);
                        Crepo.RemoveCourse(deletedid);
                        break;

                    case 5:
                        Console.Clear();
                        exit=true;
                        break;

                    default:
                        Console.WriteLine("You selected a invalid option!");
                        break;





                }

            }
        }
    }
}
