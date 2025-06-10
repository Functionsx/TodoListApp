using System.ComponentModel.DataAnnotations;

namespace TodoListWebApi
{
    public class TodoItem
    {
        public int Id { get; set; }        
        [Required]
        [StringLength(100)]
        public required string Title { get; set; }        
        [StringLength(500)]
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
