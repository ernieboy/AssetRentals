using AssetRentals.Infrastructure.EntityFramework;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AssetRentals.AdminArea.Pages.ManageAssetTypes
{
    public class IndexModel : PageModel
    {
        private readonly AssetRentalsContext _assetRentalsContext;
        

        public IndexModel(AssetRentalsContext assetRentalsContext)
        {
            _assetRentalsContext = assetRentalsContext;
        }
        public void OnGet()
        {
            AssetTypes = _assetRentalsContext.AssetTypes.ToList().Select(vm =>
                new AssetTypesListingViewModel(vm.Name,vm.Description));

        }

        public IEnumerable<AssetTypesListingViewModel> AssetTypes { get; set; } 
    }
}
