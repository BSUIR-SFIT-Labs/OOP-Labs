using System;

namespace Domain.Model.NonAlcoholic
{
    [Serializable]
    public abstract class NonAlcoholic : Drink
    {
        public float SugarContent { get; set; }
    }
}
