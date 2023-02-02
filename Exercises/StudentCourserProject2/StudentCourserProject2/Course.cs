using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StudentCourserProject2
{
    internal class Course
    {
        private double minGradeForApproval = 5.0;
        public int courseId { get; set; }
        public string studentName { get; set; }
        public double finalGrade { get; set; }

        private string courseStatus = "";
        public string GetCourseStatus() {
            return this.courseStatus;
        }

        public Course(int courseId,string studentName) { 
            this.courseId = courseId;
            this.studentName= studentName;
        }

        public void IsApproved() {
            if (this.finalGrade > this.minGradeForApproval) {
                this.courseStatus = "Pass";
            } else
            {
                this.courseStatus = "Fail";
            }

        }
        public override string ToString()
        {
            string studResult = $"CourseID: {this.courseId}\nStudent Name: {this.studentName}\nFinal Grade: {this.finalGrade}\nCourse Status:{this.GetCourseStatus()}";
            return studResult;
        }
    }
}
