namespace DMproject.Models
{
	public class Campaign
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }
		public string DungeonMaster { get; set; }
		public string World {  get; set; }
		public string? RpgSystem { get; set; }
	}
}
