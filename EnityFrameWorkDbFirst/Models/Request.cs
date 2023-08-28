using System;
using System.Collections.Generic;

namespace EnityFrameWorkDbFirst.Models;

public partial class Request
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public string Justification { get; set; } = null!;

    public string? RejectionReason { get; set; }

    public string DelieveryMode { get; set; } = null!;

    public string Status { get; set; } = null!;

    public decimal Total { get; set; }

    public int UserId { get; set; }

    public virtual ICollection<RequestLine> RequestLines { get; set; } = new List<RequestLine>();

    public virtual User User { get; set; } = null!;
}
