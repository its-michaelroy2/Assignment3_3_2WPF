using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_3_2WPF
{
    internal class MockData
    {
        public static List<Student> Students;

        public static List<Student> CreateData()
        {
            Students = new List<Student>
    {
        new Student() { StudentId = 1, FirstName = "John", LastName = "Doe", Address = "123 Main St", MonthOfAdmission = Month.Jan, Grade = 'A' },
        new Student() { StudentId = 2, FirstName = "Jane", LastName = "Doe", Address = "456 Elm St", MonthOfAdmission = Month.Feb, Grade = 'B' },
        new Student() { StudentId = 3, FirstName = "Bob", LastName = "Smith", Address = "789 Oak St", MonthOfAdmission = Month.Mar, Grade = 'C' },
        new Student() { StudentId = 4, FirstName = "Alice", LastName = "Johnson", Address = "321 Pine St", MonthOfAdmission = Month.Apr, Grade = 'D' },
        new Student() { StudentId = 5, FirstName = "Charlie", LastName = "Brown", Address = "654 Cedar St", MonthOfAdmission = Month.May, Grade = 'C' }
    };
            return Students;
        }
    }
}
