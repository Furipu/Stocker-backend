﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class CountryModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string CountryName { get; set; }

        
    }
}
