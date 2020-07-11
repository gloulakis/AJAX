namespace AjaxWebApi.Controllers.Api
{
    using AjaxWebApi.Domain;
    using AjaxWebApi.Models;
    using AjaxWebApi.Services;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

    [Route("api/[controller]")]
    [ApiController]
    public class ChessSorterController : ControllerBase
    {
        private IChessFigureService chessFigureService;

        public ChessSorterController(IChessFigureService chessFigureService)
        {
            this.chessFigureService = chessFigureService;
        }

        [HttpGet]
        [Route("name")]
        public IEnumerable<ChessFiguresViewModel> OrderByName()
        {
            return Map(chessFigureService.OrderByName());
        }

        private IEnumerable<ChessFiguresViewModel> Map(IEnumerable<ChessFigure> figures)
        {
            var result = new List<ChessFiguresViewModel>();
            int order = 0;
            foreach (var f in figures)
            {
                var figure = new ChessFiguresViewModel
                {
                    Order = order++,
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

    }
}