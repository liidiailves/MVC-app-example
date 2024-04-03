using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

namespace eTickets.Components
{
    public class PagerViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(PagedResultBase result, string viewName)
        {
            result.LinkTemplate = Url.Action(RouteData.Values["action"].ToString(), new { page = "{0}" });

            return await Task.FromResult(View(viewName, result));
        }
    }
}
