using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirtsproject.semester2
{

    class Program
    {
        static void Main()
        {
           

        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Student(string fn, string ln)
        {

            this.FirstName = fn;
            this.LastName = ln;

        }
        // 

        public virtual string GetFullName
        {
            get
            {
                return "Student`s Name : " + FirstName + " " + LastName;
            }


        }
    }
    // child-klasse Teacher
    class Teacher : Student
    {
        public Teacher(string fn, string ln) : base(fn, ln)
        {
            this.FirstName = fn;
            this.LastName = ln;
        }
        // override teacher
        public override string GetFullName
        {
            get
            {
                return "Teacher`s Name: " + this.FirstName + " " + this.LastName;
            }
        }
    }
}
