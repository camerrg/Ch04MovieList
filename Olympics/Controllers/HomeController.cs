using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Olympics.Models;

namespace Olympics.Controllers
{
    public class HomeController : Controller
    {

        private List<CountryModel> Countries;

        public HomeController()
        {
            Countries = new List<CountryModel>() {
                new CountryModel() { Id = 1, Country = "Canada", Flag = "https://cdn.countryflags.com/thumbs/canada/flag-400.png", Game = "Winter Olympics", Sport = "Curling", Type = CountryModel.SportType.Indoor },
                new CountryModel() { Id = 2, Country = "Sweden", Flag = "https://cdn.countryflags.com/thumbs/sweden/flag-400.png", Game = "Winter Olympics", Sport = "Curling", Type = CountryModel.SportType.Indoor },
                new CountryModel() { Id = 3, Country = "Great Britain", Flag = "https://cdn.countryflags.com/thumbs/united-kingdom/flag-800.png", Game = "Winter Olympics", Sport = "Curling", Type = CountryModel.SportType.Indoor },
                 new CountryModel() { Id = 4, Country = "Jamaica", Flag = "https://cdn.countryflags.com/thumbs/jamaica/flag-400.png", Game = "Winter Olympics", Sport = "Bobsleigh", Type = CountryModel.SportType.Outdoor },
                 new CountryModel() { Id = 5, Country = "Italy", Flag = "https://cdn.countryflags.com/thumbs/italy/flag-400.png", Game = "Winter Olympics", Sport = "Bobsleigh", Type = CountryModel.SportType.Outdoor },
                 new CountryModel() { Id = 6, Country = "Japan", Flag = "https://cdn.countryflags.com/thumbs/japan/flag-400.png", Game = "Winter Olympics", Sport = "Bobsleigh", Type = CountryModel.SportType.Outdoor },
                 new CountryModel() { Id = 7, Country = "Germany", Flag = "https://cdn.countryflags.com/thumbs/germany/flag-400.png", Game = "Summer Olympics", Sport = "Diving", Type = CountryModel.SportType.Indoor },
                 new CountryModel() { Id = 8, Country = "China", Flag = "https://cdn.countryflags.com/thumbs/china/flag-400.png", Game = "Summer Olympics", Sport = "Diving", Type = CountryModel.SportType.Indoor },
                 new CountryModel() { Id = 9, Country = "Mexico", Flag = "https://cdn.countryflags.com/thumbs/mexico/flag-400.png", Game = "Summer Olympics", Sport = "Diving", Type = CountryModel.SportType.Indoor },
                 new CountryModel() { Id = 10, Country = "Brazil", Flag = "https://cdn.countryflags.com/thumbs/brazil/flag-400.png", Game = "Winter Olympics", Sport = "Road Cycling", Type = CountryModel.SportType.Outdoor },
                 new CountryModel() { Id = 11, Country = "Netherlands", Flag = "https://cdn.countryflags.com/thumbs/netherlands/flag-400.png", Game = "Summer Olympics", Sport = "Road Cycling", Type = CountryModel.SportType.Outdoor },
                 new CountryModel() { Id = 12, Country = "USA", Flag = "https://cdn.countryflags.com/thumbs/united-states-of-america/flag-800.png", Game = "Summer Olympics", Sport = "Road Cycling", Type = CountryModel.SportType.Outdoor },
                 new CountryModel() { Id = 13, Country = "Thailand", Flag = "https://cdn.countryflags.com/thumbs/thailand/flag-400.png", Game = "Paralympics", Sport = "Archery", Type = CountryModel.SportType.Indoor },
                 new CountryModel() { Id = 14, Country = "Uruguay", Flag = "https://cdn.countryflags.com/thumbs/uruguay/flag-400.png", Game = "Paralympics", Sport = "Archery", Type = CountryModel.SportType.Indoor },
                 new CountryModel() { Id = 15, Country = "Ukraine", Flag = "https://cdn.countryflags.com/thumbs/ukraine/flag-400.png", Game = "Paralympics", Sport = "Archery", Type = CountryModel.SportType.Indoor },
                 new CountryModel() { Id = 16, Country = "Austria", Flag = "https://cdn.countryflags.com/thumbs/austria/flag-400.png", Game = "Paralympics", Sport = "Canoe Sprint", Type = CountryModel.SportType.Outdoor },
                 new CountryModel() { Id = 17, Country = "Pakistan", Flag = "https://cdn.countryflags.com/thumbs/pakistan/flag-400.png", Game = "Paralympics", Sport = "Canoe Sprint", Type = CountryModel.SportType.Outdoor },
                 new CountryModel() { Id = 18, Country = "Zimbabwe", Flag = "https://cdn.countryflags.com/thumbs/zimbabwe/flag-400.png", Game = "Paralympics", Sport = "Canoe Sprint", Type = CountryModel.SportType.Outdoor },
                 new CountryModel() { Id = 19, Country = "France", Flag = "https://cdn.countryflags.com/thumbs/france/flag-400.png", Game = "Youth Olympic Games", Sport = "Breakdancing", Type = CountryModel.SportType.Indoor },
                 new CountryModel() { Id = 20, Country = "Cyprus", Flag = "https://cdn.countryflags.com/thumbs/cyprus/flag-400.png", Game = "Youth Olympic Games", Sport = "Breakdancing", Type = CountryModel.SportType.Indoor },
                 new CountryModel() { Id = 21, Country = "Russia", Flag = "https://cdn.countryflags.com/thumbs/russia/flag-400.png", Game = "Youth Olympic Games", Sport = "Breakdancing", Type = CountryModel.SportType.Indoor },
                 new CountryModel() { Id = 22, Country = "Finland", Flag = "https://cdn.countryflags.com/thumbs/finland/flag-400.png", Game = "Youth Olympic Games", Sport = "Skateboarding", Type = CountryModel.SportType.Outdoor},
                 new CountryModel() { Id = 23, Country = "Slovakia", Flag = "https://cdn.countryflags.com/thumbs/slovakia/flag-400.png", Game = "Youth Olympic Games", Sport = "Skateboarding", Type = CountryModel.SportType.Outdoor },
                 new CountryModel() { Id = 24, Country = "Portugal", Flag = "https://cdn.countryflags.com/thumbs/portugal/flag-400.png", Game = "Youth Olympic Games", Sport = "Skateboarding", Type = CountryModel.SportType.Outdoor }
            };
        }

        public ActionResult Index(string Value = "All", string Filter = "All")
        {
            List<CountryModel> sortedCountries;

            if (Filter == "All")
            {
                sortedCountries = Countries.OrderBy(c => c.Country).ToList();
            }
            else if (Filter == "Game")
            {
                sortedCountries = Countries.Where(g => g.Game == Value).OrderBy(c => c.Country).ToList();
            } else if (Filter == "Category")
            {
                sortedCountries = Countries.Where(c => c.Sport == Value).OrderBy(c => c.Country).ToList();
            } else
            {
                sortedCountries = new List<CountryModel>();
            }
            
            return View(sortedCountries);
        }

        public ActionResult Country(int Id)
        {
            DisplayModel displayModel = new DisplayModel();

            displayModel.SelectedCountry = Countries.Where(country => country.Id == Id).FirstOrDefault();
            displayModel.Countries = Countries.Where(c => c.Id != Id).OrderBy(c => c.Country).ToList();

            return View(displayModel);

            //CountryModel countryModel = Countries.Where(country => country.Id == Id).FirstOrDefault();

            //return View(countryModel);
        }


    }
}