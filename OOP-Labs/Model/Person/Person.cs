using System;
using System.ComponentModel;

namespace OOP_Labs.Model.Person
{
    class Person
    {
        [Description("Name")]
        public string Name { get; set; }

        [Description("Surname")]
        public string Surname { get; set; }

        [Description("Date of Birth")]
        public DateTime DateOfBirth { get; set; }
    }
}
