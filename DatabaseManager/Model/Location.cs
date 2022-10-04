namespace DatabaseManager.Model
{
    public partial class Location
    {
        public long LocationId { get; set; }
        public string? LocationName { get; set; }
        public string? LocationType { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? CityName { get; set; }
        public string? MunicipalityName { get; set; }
        public string? StateName { get; set; }
        public string? StateCode { get; set; }
        public string? CountryName { get; set; }
        public string? CountryCode { get; set; }
        public string? PostalCode { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public long? DeleteSessionId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
