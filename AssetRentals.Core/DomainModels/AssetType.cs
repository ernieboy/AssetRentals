namespace AssetRentals.Core.DomainModels
{
    public class AssetType : BaseEntity
    {
        public AssetType(string name, string description)
        {
            ArgumentNullException.ThrowIfNull(name, nameof(name));
            ArgumentNullException.ThrowIfNull(description, nameof(description));

            Name = name;
            Description = description;
        }

        public string Name { get; private set; }

        public string Description { get; private set; }       
    }
}
