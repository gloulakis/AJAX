namespace AjaxWebApi.Services
{
    using AjaxWebApi.Domain;
    using System.Collections.Generic;

    public interface IChessFigureService
    {
        IEnumerable<ChessFigure> GetAll();

        IEnumerable<ChessFigure> OrderByName();
    }
}
