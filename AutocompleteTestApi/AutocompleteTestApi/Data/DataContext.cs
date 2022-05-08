using AutocompleteTestApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AutocompleteTestApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<City> Cities { get; set; }
    }
}
