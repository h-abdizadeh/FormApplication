using System.ComponentModel.DataAnnotations;
namespace FardaTaxi.Models;

public class Driver
{
    [Key]
    public int Id { get; set; }
    public string Fname { get; set; }
    public string Lname { get; set; }
    public string Phone { get; set; }
    public bool Status { get; set; } = true;
    public int? Order { get; set; }//(?) ==> nullable
    public string? FaceImg { get; set; }


}
