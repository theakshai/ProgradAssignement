using Microsoft.EntityFrameworkCore;
using System.Security.Permissions;
using TextEditor.Models;
namespace TextEditor.Data
{
    public class DocumentContext : DbContext
    {

        public DocumentContext(DbContextOptions<DocumentContext>options):base(options) { } 

        public DbSet<Document> Documents { get; set;}
    }
}
