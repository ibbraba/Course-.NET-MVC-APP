using Microsoft.EntityFrameworkCore;
using TutorialYTWeb.Models;

namespace TutorialYTWeb.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        //Add Entity to DB (table name will be Categories)
        public DbSet<Category> Categories { get; set; }


    }
}
