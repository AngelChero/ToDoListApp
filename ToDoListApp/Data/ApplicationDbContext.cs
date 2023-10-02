using Microsoft.EntityFrameworkCore;
using ToDoListApp.Entities;

namespace ToDoListApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<TaskData> TaskDatas { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<FileAttached> FileAttacheds { get; set; }
    }
}
