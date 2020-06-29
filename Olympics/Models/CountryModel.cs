using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Olympics.Models
{
    public class CountryModel
    {
        public int Id { get; set; }

        public string Country { get; set; }

        public string Game { get; set; }

        public string Sport { get; set; }

        public SportType Type { get; set; }

        public string Flag { get; set; }

        public enum SportType
        {
            Indoor,
            Outdoor
        }

    }
}