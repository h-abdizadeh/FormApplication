
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

namespace Taxi.Models;

public class Driver
{
    [Key]
    //[DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public string Fname { get; set; }
    public string Lname { get; set; }
    public bool State { get; set; } = true;
    public int? Order { get; set; }

    public string? FaceImg { get; set; }
}
