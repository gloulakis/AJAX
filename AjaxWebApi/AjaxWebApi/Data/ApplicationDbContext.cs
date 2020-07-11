namespace AjaxWebApi.Data
{
    using AjaxWebApi.Domain;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opt)
            :base(opt)
        {

        }

        public DbSet<ChessFigure> ChessFigures { get; set; }
    }
}
