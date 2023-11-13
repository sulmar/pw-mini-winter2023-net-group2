namespace Domain.Model;

public class User
{
    public bool IsAdmin { get; set; }
    public byte Age { get; set; }

    public static byte AdultAge => 18;

    public bool IsAdult => Age >= AdultAge;
}

public class Rent
{
    public User Rentee { get; set; }

    public bool CanReturn(User user)
    {
        if (user == null)
            throw new ArgumentNullException("user");

        return user.IsAdmin || user == Rentee && user.IsAdult;
    }
}
