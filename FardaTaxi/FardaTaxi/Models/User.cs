using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FardaTaxi.Models;

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public string Fname { get; set; }
    public string Lname { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }

}
