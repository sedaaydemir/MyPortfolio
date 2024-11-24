using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.LayoutComponents
{
	public class _LayoutNavbarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{

		return View(); 
		}	
	}
}
