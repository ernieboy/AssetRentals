using AssetRentals.Core.DomainModels;
using AssetRentals.Infrastructure.EntityFramework;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AssetRentals.AdminArea.Pages.ManageAssetTypes
{
    public class AddModel : PageModel
    {
        private readonly AssetRentalsContext _assetRentalsContext;

        public AddModel(AssetRentalsContext assetRentalsContext)
        {
            _assetRentalsContext = assetRentalsContext;
        }
        public async Task OnPost(AddAssetTypeViewModel viewModel)
        {
            ArgumentNullException.ThrowIfNull(viewModel, nameof(viewModel));
            ArgumentNullException.ThrowIfNull(viewModel.Name, nameof(viewModel.Name));
            ArgumentNullException.ThrowIfNull(viewModel.Description, nameof(viewModel.Description));

            var assetType = new AssetType(viewModel.Name, viewModel.Description);
            await _assetRentalsContext.AddAsync(assetType);
            await _assetRentalsContext.SaveChangesAsync();
        }
    }
}
