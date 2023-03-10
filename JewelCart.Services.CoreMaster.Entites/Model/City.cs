using System.ComponentModel.DataAnnotations.Schema;

namespace JewelCart.Services.CoreMaster.Entites.Model
{
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
}

