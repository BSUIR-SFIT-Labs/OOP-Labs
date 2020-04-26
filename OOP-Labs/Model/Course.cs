using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace OOP_Labs.Model
{
    class Course
    {
        [Description("Name")]
        public string Name { get; set; }

        [Description("Description")]
        public string Description { get; set; }

        [Description("Cabinet")]
        public Cabinet.Cabinet Cabinet { get; set; }

        [Description("Time")]
        public List<DateTime> Time { get; set; }
    }
}
