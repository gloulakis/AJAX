namespace AjaxWebApi.Controllers
{
    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
    using AjaxWebApi.Models;
    using AjaxWebApi.Services;
    using AjaxWebApi.Domain;
    using System.Collections.Generic;

    public class HomeController : Controller
    {
        private readonly IChessFigureService chessFigureService;

        public HomeController(IChessFigureService chessFigureService)
        {
            this.chessFigureService = chessFigureService;
        }

        public IActionResult Index()
        {
            var figures = chessFigureService.GetAll();

            var model = Map(figures);

            return View(model);
        }

        private IEnumerable<ChessFiguresViewModel> Map(IEnumerable<ChessFigure> figures)
        {
            var result = new List<ChessFiguresViewModel>();

            foreach (var f in figures)
            {
                var figure = new ChessFiguresViewModel
                {
                    Name = f.Name,
                    Power = f.Power,
                    MaxRange = f.MaxRange,
                    MinRange = f.MinRange,
                    ImageUrl = f.ImageUrl
                };

                result.Add(figure);
            }

            return result;
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
