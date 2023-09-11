using RepositorySamples.Framework;

public class CategoryCreated:IDomainEvent
{
    public string Title { get; }

    public CategoryCreated(string title)
    {
        Title = title;
    }
}
