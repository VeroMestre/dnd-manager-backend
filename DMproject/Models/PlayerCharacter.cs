namespace DMproject.Models
{
	public class PlayerCharacter
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public int? Level { get; set; }
		public string? Class {  get; set; }
		public string? Subclass { get; set; }
		public string? Race { get; set; }
		public string? Subrace { get; set; }
		public string? Background { get; set; }
		public string? Description { get; set; }
		public string? Backstory { get; set; }
		public Guid CampaignId {  get; set; }
		public Guid UserId { get; set; }
	}
}
