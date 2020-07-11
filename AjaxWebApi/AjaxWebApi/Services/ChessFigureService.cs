namespace AjaxWebApi.Services
{
    using AjaxWebApi.Data.Repositories;
    using AjaxWebApi.Domain;
    using Microsoft.VisualStudio.Web.CodeGeneration.Templating;
    using System.Collections.Generic;
    using System.Linq;

    public class ChessFigureService : IChessFigureService
    {
        private IChessRepository chessRepository;

        public ChessFigureService(IChessRepository chessRepository)
        {
            this.chessRepository = chessRepository;
        }

        public IEnumerable<ChessFigure> GetAll()
        {
            return chessRepository.GetAll();
        }

        public IEnumerable<ChessFigure> OrderByName()
        {
            return GetAll().OrderBy(x => x.Name);
        }
    }
}
