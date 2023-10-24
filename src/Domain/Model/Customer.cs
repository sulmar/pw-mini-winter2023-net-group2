namespace Domain.Model;

public class Customer : BaseEntity
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
