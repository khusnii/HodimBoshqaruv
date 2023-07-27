using HodimBoshqaruv.Models;
using HodimBoshqaruv.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HodimBoshqaruv.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStaffRepository staffRepository;

        public HomeController(ILogger<HomeController> logger, IStaffRepository staffRepository)
        {
            _logger = logger;
            this.staffRepository = staffRepository;
        }

        public IActionResult Index()
        {
            HomeIndexViewModel viewModel = new HomeIndexViewModel()
            {
                Staffs = staffRepository.GetAll()
            };
            
            return View(viewModel);
        }

        public ViewResult Details(int? id)
        {

            HomeDetailsViewModel viewModel = new HomeDetailsViewModel()
            {
                Title = "Details",
                Staff = staffRepository.Get(id??1)
            };
            return View(viewModel);
        }
 
        public string Staff(int id)
        {
            return staffRepository.Get(id)?.FirstName;
        }


    }
}