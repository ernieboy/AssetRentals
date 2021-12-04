namespace AssetRentals.Core.DomainModels
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
            RecordCreatedDate = DateTime.UtcNow;
        }

        public Guid? Id { get; protected set; }

        public DateTime RecordCreatedDate { get; protected set; }

        public DateTime? RecordLastUpdatedDate { get; protected set; }   
    }
}
