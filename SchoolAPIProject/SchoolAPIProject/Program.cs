using Models;
using Roles;

class Program
{
    static void Main()
    {
        // Админ създава учител и модератор
        var admin = new AdminService();
        admin.CreateTeacher("Mr. Ivanov");
        admin.CreateModerator("Ms. Petrova");

        // Учител създава клас и добавя предмети
        var teacher = new TeacherService();
        var classA = teacher.CreateClass("5A");
        teacher.AddSubject(classA, new Subject { Name = "Math" });
        teacher.AddSubject(classA, new Subject { Name = "History" });

        // Добавяне на ученик
        var student1 = new Student { Name = "Petar" };
        teacher.AddStudent(classA, student1);
        teacher.AssignGrade(student1, "Math", 5.50);

        // Родител на ученика
        var parent = new Parent { Name = "Mr. Petrov", Children = new List<Student> { student1 } };
        var parentService = new ParentService();
        parentService.ViewGrades(parent);

        // Преместване на ученик в нов клас
        var classB = teacher.CreateClass("5B");
        teacher.AddSubject(classB, new Subject { Name = "Math" });
        teacher.AddSubject(classB, new Subject { Name = "Biology" });

        var moderator = new ModeratorService();
        moderator.MoveStudent(student1, classA, classB);

        // Изтриване на празен клас
        var allClasses = new List<Classroom> { classA, classB };
        moderator.DeleteEmptyClass(allClasses, classA);
    }
}
