using System.ComponentModel.DataAnnotations;

namespace KeepNoteAPI.Classes
{
	public class Note
	{
		public int Id { get; set; }
		[MaxLength(200)]
		public string Title { get; set; } = null!;
		public string? Content { get; set; }
	}
}
