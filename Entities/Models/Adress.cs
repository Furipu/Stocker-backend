namespace Entities.Models
{
    public class Adress
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int? StreetNumber { get; set; }
        public string StreetBus { get; set; }
        
        public int? PostCityId { get; set; }
        public PostCity PostCity { get; set; }
        public int? CountryId { get; set; }
        public Country Country { get; set; }
        public Brand Brand { get; set; }
        public Supplier Supplier { get; set; }
    }
}
