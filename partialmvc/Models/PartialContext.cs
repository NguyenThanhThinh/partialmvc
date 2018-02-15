using System.Data.Entity;

namespace partialmvc.Models
{
    public class PartialContext:DbContext
    {
        public PartialContext() : base("PartialContext")
        {

        }
        public DbSet<Category> Categorys { get; set; }
    }
}