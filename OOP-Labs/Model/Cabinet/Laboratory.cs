using System.ComponentModel;

namespace OOP_Labs.Model.Cabinet
{
    class Laboratory : Cabinet
    {
        [Description("Computers exist")]
        public bool IsComputersExist { get; set; }

        [Description("Equipment exist")]
        public bool IsEquipmentExist { get; set; }
    }
}
