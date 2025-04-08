// Roles/AdminService.cs
public class AdminService
{
    public void CreateTeacher(string name)
    {
        Console.WriteLine($"Teacher {name} created.");
    }

    public void CreateModerator(string name)
    {
        Console.WriteLine($"Moderator {name} created.");
    }
}
