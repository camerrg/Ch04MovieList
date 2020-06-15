using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneContacts.Models
{
    public class Phone
    {
        //ef core will configure the database to generate this value
        public int PhoneId { get; set; }

        // must enter a name for contact to be saved 
        [Required (ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        //required to enter a phone number for contact 
        [Required (ErrorMessage= "Please enter a phone number.")]
        [Range (0,9, ErrorMessage = " Number must be between 0 and 9.")]
        public long? PhoneNum { get; set; }

        //optional to add address for contact 
        public string Address { get; set; }

        //optional for notes 
        public string Notes { get; set; }

        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + '-' + PhoneNum?.ToString();


    }
}
