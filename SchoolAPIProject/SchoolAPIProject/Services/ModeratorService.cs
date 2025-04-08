// Roles/ModeratorService.cs
public class ModeratorService
{
    public void MoveStudent(Student student, Classroom oldClass, Classroom newClass)
    {
        if (!newClass.CanAddStudent)
            return;

        oldClass.Students.Remove(student);
        newClass.Students.Add(student);

        // Прехвърляне на оценки, ако предметите съвпадат
        var newGrades = new List<Grade>();
        foreach (var subj in newClass.Subjects)
        {
            var oldGrade = student.Grades.FirstOrDefault(g => g.Subject.Name == subj.Name);
            newGrades.Add(oldGrade ?? new Grade { Subject = subj, Value = 0 });
        }
        student.Grades = newGrades;
    }

    public void DeleteEmptyClass(List<Classroom> classes, Classroom classroom)
    {
        if (classroom.IsEmpty)
        {
            classes.Remove(classroom);
        }
    }
}
