using Microsoft.AspNetCore.Mvc;
using MIDAS_Fitness.Models;
using System.Security.Cryptography;
using System.Text;

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

        [HttpGet]

        [HttpPost]
        public async Task<IActionResult> Details(int id, PersonalDetails model, string confirmPassword, IFormFile profilePhoto, string takePhotoData)
        {
            if (!ModelState.IsValid || model.PasswordHash != confirmPassword)
            {
                if (model.PasswordHash != confirmPassword)
                    ModelState.AddModelError("PasswordHash", "Passwords do not match.");
                return View(model);
            }

            // Hash the password
            using var sha256 = SHA256.Create();
            var hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(model.PasswordHash));
            model.PasswordHash = Convert.ToBase64String(hash);

            // Handle image upload (either file or base64 from camera)
            string assetsPath = Path.Combine(Directory.GetCurrentDirectory(), "Assets");
            if (!Directory.Exists(assetsPath))
                Directory.CreateDirectory(assetsPath);

            if (profilePhoto != null && profilePhoto.Length > 0)
            {
                var fileName = $"{Guid.NewGuid()}{Path.GetExtension(profilePhoto.FileName)}";
                var filePath = Path.Combine(assetsPath, fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await profilePhoto.CopyToAsync(stream);
                }
                model.ProfilePhotoPath = fileName;
            }
            else if (!string.IsNullOrEmpty(takePhotoData))
            {
                // takePhotoData is expected to be a base64 string: "data:image/png;base64,...."
                var base64Data = takePhotoData.Substring(takePhotoData.IndexOf(",") + 1);
                var bytes = Convert.FromBase64String(base64Data);
                var fileName = $"{Guid.NewGuid()}.png";
                var filePath = Path.Combine(assetsPath, fileName);
                await System.IO.File.WriteAllBytesAsync(filePath, bytes);
                model.ProfilePhotoPath = fileName;
            }

            // TODO: Save 'model' to your database (EF Core or other)
            // Example: _context.PersonalDetails.Add(model); await _context.SaveChangesAsync();

            // Redirect or show success
            return RedirectToAction("Payment");
        }
    }
}
