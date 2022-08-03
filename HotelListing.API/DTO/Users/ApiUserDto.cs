﻿using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.DTO.Users
{
    public class ApiUserDto : LoggingDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        
    }
}
