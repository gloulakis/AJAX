namespace AjaxWebApi.Data.Repositories
{
    using System.Collections.Generic;
    using AjaxWebApi.Domain;

    public  interface IChessRepository
    {
        IEnumerable<ChessFigure> GetAll();
    }
}
