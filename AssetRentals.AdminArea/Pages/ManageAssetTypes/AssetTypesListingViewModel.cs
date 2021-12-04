namespace AssetRentals.AdminArea.Pages.ManageAssetTypes
{
    public class AssetTypesListingViewModel
    {
        public AssetTypesListingViewModel(string name, string description)
            => (Name, Description) = (name, description);


        public string Name { get; init; }

        public string Description { get; init; }
    }
}
