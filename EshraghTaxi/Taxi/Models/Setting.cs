﻿

using System.ComponentModel.DataAnnotations;

namespace Taxi.Models;

public class Setting
{
    [Key]
    public int Id { get; set; }

    public string Logo { get; set; }
}
