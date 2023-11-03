
using System.ComponentModel.DataAnnotations;

namespace Taxi.Models;

public class User
{
    [Key]
    //[DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public string Fname { get; set; }
    public string Lname { get; set; }
    public string Mobile { get; set; }
    public string Code { get; set; }
    public string Address { get; set; }
}
