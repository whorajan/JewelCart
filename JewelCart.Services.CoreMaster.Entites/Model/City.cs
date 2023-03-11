using System.ComponentModel.DataAnnotations.Schema;

namespace JewelCart.Services.CoreMaster.Entites.Model
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public class City
	{
        public Guid Id { get; set; }

        public string Name { get; set; }

        public State State { get; set; }

        public Country Country { get; set; }

        [Column(TypeName = "decimal(10,8")]
        public decimal Latitude { get; set; }

        [Column(TypeName = "decimal(11,8")]
        public decimal Longitude { get; set; }

        public string CreateLogId { get; set; }
    }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
}

