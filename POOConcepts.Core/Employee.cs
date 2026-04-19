using System;
using System.Collections.Generic;
using System.Text;

namespace POOConcepts.Core;

public abstract class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public Date BornDate { get; set; } = null!;
    public Date HireDate { get; set; } = null!;

    public abstract decimal GetValueToPay();
    public override string ToString() => 
        $"{Id}\t{FirstName} {LastName}\n\t" + 
        $"Born date......: {BornDate}\n\t" + 
        $"Hire date......: {HireDate}"; 
}
