using RepositorySamples.Framework;

namespace RepositorySample.Domain.Products.Entities
{
    public class Product : AggregateRoot
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int Price { get; private set; }

        public int CategoryId { get; private set; }

        private List<Discount> _discounts = new();
        public IReadOnlyList<Discount> Discounts => _discounts;

        public Product(string title, string description, int price, int categoryid)
        {
            Title = title;
            Description = description;
            Price = price;
            CategoryId = categoryid;
            AddEvent(new ProductCreated(title, description, price, categoryid));
        }

        public void AddDiscount(string title, int value)
        {
            Discount discount = new Discount(title, value);
            _discounts.Add(discount);
            AddEvent(new DiscountCreated(Id, title, value));
        }
    }

    public class Discount : Entity
    {
        public string Title { get; private set; }
        public int Value { get; private set; }
        public Discount(string title, int value)
        {
            Title = title;
            Value = value;
        }
    }
}
