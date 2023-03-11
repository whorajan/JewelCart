using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JewelCart.Services.CoreMaster.Entites.Model
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public class State
	{
        public Guid Id { get; set; }

        [StringLength(255, ErrorMessage = "")]
        public string Name { get; set; }

        public Country Country { get; set; }

        [StringLength(255, ErrorMessage = "")]
        public string StateCode { get; set; }

        [StringLength(2, ErrorMessage = "")]
        public string? iso2 { get; set; }

        public string type { get; set; }

        [Column(TypeName = "decimal(10,8")]
        public decimal Latitude { get; set; }

        [Column(TypeName = "decimal(11,8")]
        public decimal Longitude { get; set; }

        public string CreateLogId { get; set; }
    }
}

