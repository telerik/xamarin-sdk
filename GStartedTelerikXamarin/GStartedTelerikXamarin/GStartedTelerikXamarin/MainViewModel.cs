using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GStartedTelerikXamarin
{
    class MainViewModel
    {
        private static string[] Categories = new string[] { "Greenings", "Perfecto", "NearBy", "Family", "Fresh" };

        public static List<CategoricalData> GetCategoricalData()
        {
            List<CategoricalData> data = new List<CategoricalData>();
            data.Add(new CategoricalData() { Value = 55, Category = Categories[0] });
            data.Add(new CategoricalData() { Value = 30, Category = Categories[1] });
            data.Add(new CategoricalData() { Value = 120, Category = Categories[2] });
            data.Add(new CategoricalData() { Value = 80, Category = Categories[3] });
            data.Add(new CategoricalData() { Value = 44, Category = Categories[4] });

            return data;
        }
    }
}
