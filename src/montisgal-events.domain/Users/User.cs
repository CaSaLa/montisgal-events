namespace montisgal_events.domain.Users;

public class User(Guid id, string name)
{
    public Guid Id { get; set; } = id;
    public string Name { get; set; } = name;
}