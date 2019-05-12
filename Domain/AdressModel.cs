namespace Domain
{
    public class AdressModel
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int? StreetNumber { get; set; }
        public string StreetBus { get; set; }
        public PostCityModel PostCity { get; set; }
        public CountryModel Country { get; set; }

    }
}
