using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.LayoutComponents
{
	public class _LayoutSideBarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{

		return View(); 
		}
		
	}
}
