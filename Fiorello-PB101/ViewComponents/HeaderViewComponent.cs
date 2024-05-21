using Fiorello_PB101.Services;
using Fiorello_PB101.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using NuGet.Configuration;

namespace Fiorello_PB101.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly ISettingService _settingService;

        public HeaderViewComponent(ISettingService settingService)
        {
            _settingService = settingService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult(View(await _settingService.GetAllAsync()));
        }
    }
}
