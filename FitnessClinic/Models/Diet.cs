using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessClinic.Models
{
    public class Diet
    {
        public int DietId { get; set; }
        public string DietName { get; set; }
        public string FoodTaken { get; set; }
        public int Calories { get; set; }
    }
}
