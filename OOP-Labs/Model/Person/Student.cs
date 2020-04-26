using System.Collections.Generic;
using System.ComponentModel;

namespace OOP_Labs.Model.Person
{
    class Student : Person
    {
        [Description("Student ID")]
        public int StudentIdNumber { get; set; }

        [Description("Average mark")]
        public float AverageMark { get; set; }

        [Description("Classes")]
        public List<Course> Classes { get; set; }
    }
}
