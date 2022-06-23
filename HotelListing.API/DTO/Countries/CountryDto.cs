using HotelListing.API.DTO.Hotels;

namespace HotelListing.API.DTO.Countries
{
    public class CountryDto : BaseCountryDto
    {
        public int Id { get; set; }
    
        public List<HotelDto> Hotels { get; set; }
    }

}
