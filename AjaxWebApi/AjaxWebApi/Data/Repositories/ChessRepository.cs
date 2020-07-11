namespace AjaxWebApi.Data.Repositories
{
    using AjaxWebApi.Domain;
    using System.Collections.Generic;
    using System.Linq;

    public class ChessRepository : IChessRepository
    {
        private ApplicationDbContext db;

        public ChessRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<ChessFigure> GetAll()
        {
            return this.db.ChessFigures.ToList();
        }
    }
}
