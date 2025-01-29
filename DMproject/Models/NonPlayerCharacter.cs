using System.Globalization;

namespace DMproject.Models
{
	public class NonPlayerCharacter
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }
		public string? Race { get; set; }
		public string? Gender { get; set; }
		public Guid? WorldId {  get; set; }
		public int? LocationId { get; set; }
		public string? Affiliation {  get; set; }
		public Guid Campaign {  get; set; }
	}
}
