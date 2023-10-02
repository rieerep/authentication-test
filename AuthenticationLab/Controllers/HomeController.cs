using AuthenticationLab.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AuthenticationLab.Controllers
{

    
    public class HomeController : Controller
    {
        private readonly UserManager<UserModel> _userManager;
        private readonly ILogger<HomeController> _logger;

        public HomeController(UserManager<UserModel> userManager)
        {
           _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(this.User);
            var viewModel = new IndexViewModel();

            if (user is not null)
            {
                viewModel.Nickname = user.Nickname;
                viewModel.FirstName = user.FirstName;
                viewModel.LastName = user.LastName;
            }

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}