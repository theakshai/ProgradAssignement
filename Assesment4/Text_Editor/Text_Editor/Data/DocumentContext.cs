using Microsoft.EntityFrameworkCore;
using Text_Editor.Models;
namespace Text_Editor.Data
{
    public class DocumentContext: DbContext
    {
        public DocumentContext(DbContextOptions<DocumentContext> options) : base(options) { }

        public DbSet<Document> Documents { get; set;}
    }
}
