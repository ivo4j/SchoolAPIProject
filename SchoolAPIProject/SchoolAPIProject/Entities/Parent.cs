// Models/Parent.cs
public class Parent
{
    public string Name { get; set; }
    public List<Student> Children { get; set; } = new();
}
