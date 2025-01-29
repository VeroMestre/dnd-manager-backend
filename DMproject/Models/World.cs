namespace DMproject.Models
{
	public class World
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }
		public string Type { get; set; }
		public string Creator { get; set; }
	}
}
