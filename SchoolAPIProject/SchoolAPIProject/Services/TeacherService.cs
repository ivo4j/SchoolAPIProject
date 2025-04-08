// Roles/TeacherService.cs
public class TeacherService
{
    public Classroom CreateClass(string name)
    {
        return new Classroom { Name = name };
    }

    public void AddStudent(Classroom classroom, Student student)
    {
        if (classroom.CanAddStudent)
        {
            classroom.Students.Add(student);
            foreach (var subject in classroom.Subjects)
            {
                student.Grades.Add(new Grade { Subject = subject, Value = 0 });
            }
        }
    }

    public void AddSubject(Classroom classroom, Subject subject)
    {
        if (classroom.CanAddSubject)
        {
            classroom.Subjects.Add(subject);
        }
    }

    public void AssignGrade(Student student, string subjectName, double gradeValue)
    {
        var grade = student.Grades.FirstOrDefault(g => g.Subject.Name == subjectName);
        if (grade != null)
        {
            grade.Value = gradeValue;
        }
    }
}
