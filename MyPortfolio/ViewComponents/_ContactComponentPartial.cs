using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ContactComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = portfolioContext.Contacts.Select(x => x.Title).FirstOrDefault();
            ViewBag.description = portfolioContext.Contacts.Select(x => x.Description).FirstOrDefault();
            ViewBag.phone1 = portfolioContext.Contacts.Select(x => x.Phone1).FirstOrDefault();
            ViewBag.phone2 = portfolioContext.Contacts.Select(x => x.Phone2).FirstOrDefault();
            ViewBag.email1 = portfolioContext.Contacts.Select(x => x.Email1).FirstOrDefault();
            ViewBag.email2 = portfolioContext.Contacts.Select(x => x.Email2).FirstOrDefault();
            ViewBag.adres = portfolioContext.Contacts.Select(x => x.Address).FirstOrDefault();

            return View(); 
        }
    }
}
