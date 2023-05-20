namespace DAL;
using BOL;
using Microsoft.EntityFrameworkCore;

public class ContextCollection : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string url = @"server=localhost;user=root;password=Linux123@;database=qna";
        optionsBuilder.UseMySQL(url);
    }
}
