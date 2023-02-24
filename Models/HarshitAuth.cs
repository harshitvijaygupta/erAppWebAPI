using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace erRelnAPI.Models;

public partial class HarshitAuth
{
    [Key]
    [StringLength(30)]
    [Unicode(false)]
    public string UserName { get; set; }

    [Required]
    [StringLength(15)]
    [Unicode(false)]
    public string Password { get; set; }
}
