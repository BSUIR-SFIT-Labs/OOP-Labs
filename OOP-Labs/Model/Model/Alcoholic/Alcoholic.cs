using System;

namespace Domain.Model.Alcoholic
{
    [Serializable]
    public abstract class Alcoholic : Drink
    {
        public float AlcoholContent { get; set; }

        public DateTime DateOfBottling { get; set; }
    }
}
