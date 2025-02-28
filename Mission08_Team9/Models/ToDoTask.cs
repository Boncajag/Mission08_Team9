using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission08_Team9.Models;

public class ToDoTask
{
    [Key]
    public int TaskId { get; set; }

    [Required]
    public string TaskName { get; set; }

    public string DueDate { get; set; }

    [Required]
    public int Quadrant { get; set; }

    [Required] // ✅ Ensure CategoryId is required
    public int CategoryId { get; set; }

    [ForeignKey("CategoryId")]
    public Category? Category { get; set; } // ✅ Make nullable (add `?`)
    
    public int Completed { get; set; }
}