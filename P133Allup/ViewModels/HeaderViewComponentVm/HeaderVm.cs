using P133Allup.Models;
using P133Allup.ViewModels.BasketViewModels;

namespace P133Allup.ViewModels.HeaderViewComponentVm
{
    public class HeaderVm
    {
        public IDictionary<string,string> Setting { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<BasketVM> BasketVMs { get; set; }
    }
}
