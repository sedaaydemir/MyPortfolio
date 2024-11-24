using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.LayoutComponents
{
	public class _LayoutHeadComponentPartial:ViewComponent

	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
