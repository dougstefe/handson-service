using Handson.Domain.Extensions;
using Handson.Shared.Entities;

namespace Handson.Domain.Entities
{
    public class Lesson : Entity
    {
        public Lesson(string name, string description, int order, int durationInSeconds, Course course)
        {
            Name = name;
            Description = description;
            Order = order;
            DurationInSeconds = durationInSeconds;
            Course = course;

            this.ThrowIfInvalid();
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Order { get; private set; }
        public int DurationInSeconds { get; private set; }
        public Course Course { get; private set; }
        public Guid CourseId { get; set; }
    }
}
