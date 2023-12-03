using System.ComponentModel;

namespace GetStartedWinForms;

public class Book
{
    public char Classification { get; set; }
    public int Number { get; set; }
    public string? Title { get; set; }

    public string? Name { get; set; }

    public int CategoryId { get; set; }
    public virtual Category Category { get; set; } = null!;
}