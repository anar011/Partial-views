using FrontToBack.Models;

namespace FrontToBack.ViewModels
{
    public class HomeVM
    {
        public Slider Slider { get; set; }
        public List<SliderImage> SliderImages { get; set; }
        public Service Service { get; set; }
    }
}
