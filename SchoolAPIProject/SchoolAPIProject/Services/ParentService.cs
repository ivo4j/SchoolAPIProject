// Roles/ParentService.cs
public class ParentService
{
    public void ViewGrades(Parent parent)
    {
        foreach (var child in parent.Children)
        {
            Console.WriteLine($"Grades for {child.Name}:");
            foreach (var grade in child.Grades)
            {
                Console.WriteLine($"  {grade.Subject.Name}: {grade.Value}");
            }
        }
    }
}
