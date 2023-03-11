namespace JewelCart.Services.CoreMaster.Entites.Model
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public class Currency
	{
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public string Symbol { get; set; }

        public string CreateLogId { get; set; }
    }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
}

