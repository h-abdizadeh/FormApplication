
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models;

public class Book
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Writer { get; set; }
    public string Publisher { get; set; }
    public string? Cover { get; set; }

    public int GroupId { get; set; }

    public bool NotExists { get; set; } = false;
}
