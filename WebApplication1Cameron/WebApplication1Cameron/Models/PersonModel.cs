using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1Cameron.Models
{
    public class PersonModel
    {
        public string Name { get; set; }

        public int BirthYear { get; set; }

        public string AgeThisYear()
        {
            int CurrentYear = DateTime.Today.Year;

            //Validate User Input
            if (BirthYear > CurrentYear)
            {
                return "The birth year can not be after the current year";
            }

            if (BirthYear == 0)
            {
                return "The birth year was not provided";
            }

            int CurrentAge = CurrentYear - BirthYear;

            return $"{Name} is {CurrentAge} years old";
        }
    }
}