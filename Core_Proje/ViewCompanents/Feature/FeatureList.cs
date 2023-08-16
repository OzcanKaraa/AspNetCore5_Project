using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewCompanents.Feature
{
    public class FeatureList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
