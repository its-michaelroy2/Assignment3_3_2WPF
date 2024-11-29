using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_3_2WPF
{
    public enum Month { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };

    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public Month MonthOfAdmission { get; set; }
        public char Grade { get; set; }

        public void AddStudent(Student student)
        {
            MockData.Students.Add(student);
        }
    }
}
