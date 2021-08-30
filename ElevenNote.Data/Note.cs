using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElevenNote.Data
{
	public class Note
	{
		[Key]
		public int NoteId { get; set; }
		[Required]
		public Guid OwnerId { get; set; }
		[Required]
		public string Title { get; set; }
		[Required]
		public string Content { get; set; }
		[Required]
		public DateTimeOffset CreatedUtc { get; set; }
		public DateTimeOffset? ModifiedUtc { get; set; }

		// One-To-Many Relationship ; One Category can have many notes
		
		[ForeignKey(nameof(Category))] 
		public int CategoryID { get; set; }  // Foreign Key --- Navigational Property
		public virtual Category Category { get; set; }  // Entity  -- What goes into the database
	}
}
