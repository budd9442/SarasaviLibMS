using System.ComponentModel;

namespace SarasaviLibMS.Classes;

public class Book
{
    public char Category { get; set; }
    public int Number { get; set; }
    public string? Title { get; set; }

    public string? Name { get; set; }

    public string? Publisher { get; set; }

    public bool Borrowable { get; set; }

    public virtual User Borrower { get; set; } = null!;
}