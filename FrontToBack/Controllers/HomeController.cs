
using FrontToBack.Data;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            Slider slider = _context.Sliders.FirstOrDefault();
          
            List<SliderImage> sliderImages = _context.SliderImages.ToList();
            Service service = _context.Services.FirstOrDefault();

            HomeVM model = new()
            {
                Slider = slider,
                SliderImages = sliderImages,
                Service = service
            };
            return View(model);
        }

    
    }
}