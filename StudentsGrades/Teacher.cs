using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsGrades
{
     class Teacher
    {
        public string TeacherName;
        public string studentName;
        public int studentId;
        public int[] grades;

        public Teacher()
        {
        }

        public Teacher(string TeacherName, string studentName, int studentId, int[] grades)
        {
            this.TeacherName = TeacherName;
            this.studentName = studentName;
            this.studentId = studentId;
            this.grades = grades;
        }

    }
}
