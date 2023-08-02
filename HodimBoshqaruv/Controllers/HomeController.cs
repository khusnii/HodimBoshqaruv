﻿using HodimBoshqaruv.Models;
using HodimBoshqaruv.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HodimBoshqaruv.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStaffRepository staffRepository;

        public HomeController(  IStaffRepository staffRepository)
        {
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
 
    }
}