using System.ComponentModel;
using SchoolTimetable.Models;

namespace SchoolTimetable.Data;

/// <summary>
/// Celý stav aplikace na jednom místě – tento objekt se později
/// uloží do JSON a z JSON načte (4. kontrolní bod).
/// </summary>
public class TimetableData
{
    public BindingList<SchoolClass> Classes { get; set; } = new();
    public BindingList<Teacher> Teachers { get; set; } = new();
    public BindingList<Classroom> Classrooms { get; set; } = new();
    public BindingList<Subject> Subjects { get; set; } = new();

    public List<Lesson> Lessons { get; set; } = new();
}
