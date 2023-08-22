using Handson.Shared.Entities;

namespace Handson.Domain.Entities
{
    public class Course : Entity
    {

        private List<Lesson> _lessons;

        public Course(string name, string title, string description, string tags)
        {
            Name = name;
            Title = title;
            Description = description;
            Tags = tags;
            _lessons = new List<Lesson>();
        }

        public string Name { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Tags { get; private set; }
        public IReadOnlyCollection<Lesson> Lessons => _lessons;
    }
}
