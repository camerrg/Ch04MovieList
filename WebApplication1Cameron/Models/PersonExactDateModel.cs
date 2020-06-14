using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1Cameron.Models
{
    public class PersonExactDateModel
    {
        public string Name { get; set; }

        // 01/01/1999
        public string BirthDate { get; set; }

        public string AgeThisYear()
        {
            int CurrentYear = DateTime.Today.Year;

            if (BirthDate == "" || BirthDate == String.Empty || BirthDate == null)
            {
                return "The birth year was not provided";
            }

            int birthMonth = int.Parse(BirthDate.Split('/')[0]);
            int birthDay = int.Parse(BirthDate.Split('/')[1]);
            int birthYear = int.Parse(BirthDate.Split('/')[2]);

            DateTime UserBirthDate = new DateTime(birthYear, birthMonth, birthDay);

            //Validate User Input
            if (UserBirthDate.Year > CurrentYear)
            {
                return "The birth year can not be after the current year";
            }

            int CurrentAge = CurrentYear - UserBirthDate.Year;

            if (DateTime.Today.Month < UserBirthDate.Month)
            {
                CurrentAge -= 1;
            }

            if (UserBirthDate.Month == DateTime.Today.Month)
            {
                if (DateTime.Today.Day < UserBirthDate.Day)
                {
                    CurrentAge -= 1;
                }
            }

            return $"{Name} is {CurrentAge} years old";
        }

    }
}
