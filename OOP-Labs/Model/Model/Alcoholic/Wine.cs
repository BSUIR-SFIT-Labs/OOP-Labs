using System.Collections.Generic;

namespace Domain.Model.Alcoholic
{
    public class Wine : Alcoholic
    {
        public string GrapeSort { get; set; }

        public int VinesAge { get; set; }

        public override Dictionary<string, string> GetDrinkInfo()
        {
            var drinkInfo = new Dictionary<string, string>
            {
                { "Name", Name },
                { "Cost", Cost.ToString() },
                { "Alcohol content", AlcoholContent.ToString() },
                { "Date of bottling", DateOfBottling.ToString()},
                { "Grape sort", GrapeSort },
                { "Vines age", VinesAge.ToString() },
                { "Bottle volume", Bottle.Volume.ToString() },
                { "Bottle color", Bottle.Color }
            };

            return drinkInfo;
        }     
    }
}
