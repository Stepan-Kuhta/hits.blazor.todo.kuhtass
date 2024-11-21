using System.ComponentModel.DataAnnotations;

namespace TodoServerApp.Data
{
	public class UserItem
	{
		public int Id { get; set; }
		[Required]
		public string? FullName { get; set; }
		[Required]
		public string Email { get; set; }
		public DateTime? RegisteredDate { get; set; }
	}
}
