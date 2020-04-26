using System.Collections.Generic;
using System.ComponentModel;

namespace OOP_Labs.Model.Person
{
    class Teacher : Person
    {
        [Description("Salary")]
        public int Salary { get; set; }

        [Description("Working hours")]
        public int WorkingHours { get; set; }

        [Description("Classes")]
        public List<Course> Classes { get; set; }
    }
}
