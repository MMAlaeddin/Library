// using Microsoft.AspNetCore.Mvc;
// using Library.Models;
// using System.Collections.Generic;
// using System.Linq;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Mvc.Rendering;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Identity;
// using System.Threading.Tasks;
// using System.Security.Claims;
// using Library.ViewModels;

// namespace Library.Controllers
// {
//   public class PatronsController : Controller
//   {
//     private readonly LibraryContext _db;
//     private readonly UserManager<ApplicationUser> _userManager;
//     public PatronsController(UserManager<ApplicationUser> userManager, LibraryContext db)
//     {
//       _userManager = userManager;
//       _db = db;
//     }

//     public ActionResult Index()
//     {
//       return View();
//     }

//     public IActionResult Register()
//     {
//       return View();
//     }

//     [HttpPost]
//     public async Task<ActionResult> Register (RegisterViewModel model)
//     {
//       ApplicationUser user = new ApplicationUser {Email = model.Email};
//       IdentityResult result = await _userManager.CreateAsync(user, model.Password);
//       if (result.Succeeded)
//       {
//         _db.Patrons.Add(new Patron() { AccountId = user.Id });
//         _db.SaveChanges();
//         return RedirectToAction("Index");
//       }
//       else
//       {
//         return View();
//       }
//     }
//   }
// }