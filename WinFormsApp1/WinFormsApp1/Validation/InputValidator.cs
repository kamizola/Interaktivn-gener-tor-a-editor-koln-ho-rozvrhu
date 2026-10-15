using SchoolTimetable.Models;

namespace SchoolTimetable.Validation;

/// <summary>Základní kontrola vstupů z formulářů.</summary>
public static class InputValidator
{
    /// <summary>
    /// Vrátí text chyby, nebo null, pokud je vstup v pořádku.
    /// </summary>
    /// <param name="name">Zadaný název.</param>
    /// <param name="shortName">Zadaná zkratka.</param>
    /// <param name="requireShortName">Má být zkratka povinná?</param>
    /// <param name="existing">Existující položky (kvůli kontrole duplicit).</param>
    /// <param name="editing">Upravovaná položka – ta se do kontroly duplicit nepočítá.</param>
    public static string? Validate(
        string? name,
        string? shortName,
        bool requireShortName,
        IEnumerable<NamedItem> existing,
        NamedItem? editing)
    {
        if (string.IsNullOrWhiteSpace(name))
            return "Název nesmí být prázdný.";

        if (requireShortName && string.IsNullOrWhiteSpace(shortName))
            return "Zkratka nesmí být prázdná.";

        var trimmed = name.Trim();
        bool duplicate = existing.Any(x =>
            !ReferenceEquals(x, editing) &&
            string.Equals(x.Name, trimmed, StringComparison.CurrentCultureIgnoreCase));

        return duplicate ? "Položka s tímto názvem už existuje." : null;
    }
}
