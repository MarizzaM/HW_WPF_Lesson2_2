using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_WPF_Lesson2_2
{
    public class Country
    {
        public string CountryName { get; set; }
        public string CapitalCity { get; set; }
        public string FlagImage { get; set; }

        public Country()
        {
        }

        public override string ToString()
        {
            return $"{CountryName} {CapitalCity} {FlagImage}";
        }
    }
}
