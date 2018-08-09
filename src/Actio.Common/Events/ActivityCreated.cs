using System;

namespace Actio.Common.Events
{
    public class ActivityCreated : IAuthenticatedEvent
    {
        public ActivityCreated(Guid id, Guid userId, string category, string description, DateTime createdAt)
        {
            this.Id = id;
            this.UserId = userId;
            this.Category = category;
            this.Description = description;
            this.CreatedAt = createdAt;

        }
        protected ActivityCreated()
        {

        }
        public Guid Id { get; }
        public Guid UserId { get; }
        public string Category { get; }
        public string Description { get; }
        public DateTime CreatedAt { get; }

    }
}