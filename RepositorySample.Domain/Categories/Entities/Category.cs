using RepositorySamples.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorySample.Domain.Categories.Entities
{
    public class Category : AggregateRoot
    {
        public string Title { get; private set; }

        public Category(string title)
        {
            Title = title;
            AddEvent(new CategoryCreated(title));
        }
    }
}
