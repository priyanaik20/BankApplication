using System;
using System.Collections.Generic;

namespace BankApplication.Entities;

public partial class Branch
{
    public int BranchId { get; set; }

    public string BranchName { get; set; } = null!;

    public string BranchCity { get; set; } = null!;
}
