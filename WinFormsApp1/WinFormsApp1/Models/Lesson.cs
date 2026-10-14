namespace SchoolTimetable.Models;

/// <summary>
/// Jedna vyučovací hodina umístěná v týdenní mřížce.
/// Odkazuje na ostatní položky přes jejich Id.
/// </summary>
public class Lesson
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid ClassId { get; set; }
    public Guid TeacherId { get; set; }
    public Guid ClassroomId { get; set; }
    public Guid SubjectId { get; set; }

    /// <summary>Den v týdnu: 0 = pondělí ... 4 = pátek.</summary>
    public int Day { get; set; }

    /// <summary>Pořadí hodiny v dni: 0 = 1. hodina, 1 = 2. hodina ...</summary>
    public int Hour { get; set; }
}
