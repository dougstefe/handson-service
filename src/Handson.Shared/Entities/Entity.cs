namespace Handson.Shared.Entities
{
    public abstract class Entity
    {
        public Entity()
        {
            Id = new Guid();
        }

        public Guid Id { get; init; }

        public DateTime? CreatedAt { get; private set; }

        public DateTime? ModifiedAt { get; private set; }

        public void Modified()
        {
            ModifiedAt = DateTime.UtcNow;
        }

        public void Created()
        {
            CreatedAt = ModifiedAt = DateTime.UtcNow;
        }
    }
}
