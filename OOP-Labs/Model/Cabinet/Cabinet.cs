using System.ComponentModel;

namespace OOP_Labs.Model.Cabinet
{
    class Cabinet
    {
        [Description("Number")]
        public int Number { get; set; }

        [Description("Floor")]
        public int Floor { get; set; }

        [Description("Number of seats")]
        public int NumberOfSeats { get; set; }
    }
}
