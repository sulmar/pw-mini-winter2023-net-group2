namespace Domain.Model;

public abstract class Base
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
}

public class Customer : Base
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName => $"{FirstName} {LastName}";
    public Gender Gender { get; set; }
}

public enum Gender
{
    Male,
    Female
}
