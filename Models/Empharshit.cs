using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace erRelnAPI.Models;

[Table("empharshit")]
public partial class Empharshit
{
    [Key]
    [Column("eid")]
    public int Eid { get; set; }

    [Column("ename")]
    [StringLength(20)]
    [Unicode(false)]
    public string Ename { get; set; }

    [Column("salary")]
    public int? Salary { get; set; }

    [Column("doj", TypeName = "date")]
    public DateTime? Doj { get; set; }

    [Column("city")]
    [StringLength(20)]
    [Unicode(false)]
    public string City { get; set; }
}
