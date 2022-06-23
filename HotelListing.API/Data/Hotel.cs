using HotelListing.API.DTO.Hotels;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.Data
{
    public class Hotel:HotelBaseDto
    {
        public int Id { get; set; }

    }
}

