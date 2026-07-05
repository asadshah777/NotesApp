using System.ComponentModel.DataAnnotations;

public class Note {
    public int Id { get; set; }

    [Required(ErrorMessage = "You must enter some content")]
    public String Content { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "You must enter a date")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; }
}