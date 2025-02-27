using System.ComponentModel.DataAnnotations;

namespace Mission08_Team9.Models;

public class Category
{
    [Key]
    public int CategoryId { get; set; }
    [Required]
    public string CategoryName { get; set; }
}