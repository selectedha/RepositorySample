using RepositorySamples.Framework;

public class DiscountCreated:IDomainEvent
{
    public string Title { get;}
    public int Value { get;}
    public long ProductId { get;}

    public DiscountCreated(long productId, string title, int value)
    {
        ProductId = productId;
        Title = title;
        Value = value;
    }
}
