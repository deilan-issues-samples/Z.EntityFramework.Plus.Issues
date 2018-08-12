using System.Threading.Tasks;
using Z.EntityFramework.Plus.Issues.N393.Entities;
using Z.EntityFramework.Plus.Issues.N393.EntityFrameworkCore;

namespace Z.EntityFramework.Plus.Issues.N393
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            using (var dbContext = new AppDbContextFactory().CreateDbContext(args))
            {
                await dbContext.Database.EnsureCreatedAsync();
                var student = new Student
                {
                    Name = "John Doe"
                };
                var audit = new Audit { CreatedBy = "ZZZ Projects" };
                dbContext.Students.Add(student);
                await dbContext.SaveChangesAsync(audit);
            }
        }
    }
}
