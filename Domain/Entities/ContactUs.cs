using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public partial class ContactUs
{
    [Key]
    public int ContactUsId { get; set; }

    [StringLength(100)]
    public string UserName { get; set; } = null!;

    [StringLength(100)]
    public string UserEmail { get; set; } = null!;

    [StringLength(2000)]
    public string MessageDetail { get; set; } = null!;
}
