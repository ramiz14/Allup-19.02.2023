using Microsoft.AspNetCore.Mvc;
using P133Allup.ViewModels.HeaderViewComponentVm;

namespace P133Allup.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(HeaderVm headerVm)
        { 
            return View(await Task.FromResult(headerVm));
        }
    }
}
