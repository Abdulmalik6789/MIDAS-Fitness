using Microsoft.AspNetCore.Mvc;
using MIDAS_Fitness.Models;

namespace MIDAS_Fitness.Controllers
{
    public class MembershipController : Controller
    {
        private static List<MembershipOffer> GetOffers() => new List<MembershipOffer>
            {
                new MembershipOffer { Id = 1, Title = "1 Year Akala", Duration = "12 months access", SignupFee = 10750, Tax = 0, FullCost = 209700, Location = "Akala" },
                new MembershipOffer { Id = 2, Title = "6 Months Akala", Duration = "6 months access", SignupFee = 6000, Tax = 0, FullCost = 120000, Location = "Akala" },
                new MembershipOffer { Id = 3, Title = "3 Months Akala", Duration = "3 months access", SignupFee = 3500, Tax = 0, FullCost = 65000, Location = "Akala" },
                new MembershipOffer { Id = 4, Title = "1 Year Bodija", Duration = "12 months access", SignupFee = 11000, Tax = 0, FullCost = 215000, Location = "Bodija" },
                new MembershipOffer { Id = 5, Title = "6 Months Bodija", Duration = "6 months access", SignupFee = 6500, Tax = 0, FullCost = 125000, Location = "Bodija" },
                new MembershipOffer { Id = 6, Title = "3 Months Bodija", Duration = "3 months access", SignupFee = 4000, Tax = 0, FullCost = 70000, Location = "Bodija" },
                new MembershipOffer { Id = 7, Title = "1 Month All Access", Duration = "1 month access", SignupFee = 2000, Tax = 0, FullCost = 25000, Location = "All Branches" }
            };

        public IActionResult Index()
        {
            var offers = GetOffers();
            return View(offers);
        }

        public IActionResult Details(int id)
        {
            var offer = GetOffers().FirstOrDefault(o => o.Id == id);
            if (offer == null) return NotFound();
            return View(offer);
        }
    }
}
