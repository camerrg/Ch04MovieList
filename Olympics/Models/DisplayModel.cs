using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Olympics.Models
{
    public class DisplayModel
    {

        public CountryModel SelectedCountry { get; set; }

        public List<CountryModel> Countries { get; set; }

    }
}