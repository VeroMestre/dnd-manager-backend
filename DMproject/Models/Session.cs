namespace DMproject.Models
{
	public class Session
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
		public DateOnly SessionDate { get; set; }
		public Guid CampaignId { get; set; }
	}
}
