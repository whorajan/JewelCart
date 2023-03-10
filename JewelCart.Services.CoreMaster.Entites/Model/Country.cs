using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JewelCart.Services.CoreMaster.Entites.Model
{
    public class Country
	{
        public Guid Id { get; set; }

        [StringLength(100, ErrorMessage = "", MinimumLength = 2)]
        public string Name { get; set; }

        [StringLength(3, ErrorMessage = "")]
        public string? iso3 { get; set; }

        public int? Numeric_Code { get; set; }

        [StringLength(2, ErrorMessage = "")]
        public string? iso2 { get; set; }

        [StringLength(255, ErrorMessage = "")]
        public string? PhoneCode { get; set; }

        [StringLength(255, ErrorMessage = "")]
        public string? Capital { get; set; }

        public Currency? Currency { get; set; }

        [StringLength(255, ErrorMessage = "")]
        public string? Native { get; set; }

        [StringLength(255, ErrorMessage = "")]
        public string? Region { get; set; }

        [StringLength(255, ErrorMessage = "")]
        public string? SubRegion { get; set; }

        public string? TimeZone { get; set; }

        [Column(TypeName = "decimal(10,8")]
        public decimal Latitude { get; set; }

        [Column(TypeName = "decimal(11,8")]
        public decimal Longitude { get; set; }

        public bool Active { get; set; }

        public string CreateLogId { get; set; }
	}
}

