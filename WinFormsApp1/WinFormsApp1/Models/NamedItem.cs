namespace SchoolTimetable.Models;

/// <summary>
/// Společný základ pro všechny položky seznamů (třída, učitel, učebna, předmět).
/// Id slouží k propojení s rozvrhovými hodinami, takže přejmenování nic nerozbije.
/// </summary>
public abstract class NamedItem
{
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>Plný název (např. "Matematika", "Jan Novák", "3.A").</summary>
    public string Name { get; set; } = "";

    /// <summary>Volitelná zkratka (např. "MAT", "NOV"). Používá se v buňkách mřížky.</summary>
    public string ShortName { get; set; } = "";

    public override string ToString() =>
        string.IsNullOrWhiteSpace(ShortName) ? Name : $"{Name} ({ShortName})";
}
