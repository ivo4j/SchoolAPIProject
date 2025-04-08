// Models/Classroom.cs
public class Classroom
{
    public string Name { get; set; }
    public List<Subject> Subjects { get; set; } = new();
    public List<Student> Students { get; set; } = new();

    public bool IsEmpty => Students.Count == 0;
    public bool CanAddStudent => Students.Count < 20;
    public bool CanAddSubject => Subjects.Count < 3;
}
