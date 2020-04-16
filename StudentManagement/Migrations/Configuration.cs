namespace StudentManagement.Migrations
{
    using StudentManagement.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentManagement.Models.StudentManagementContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StudentManagement.Models.StudentManagementContext context)
        {
                context.Students.AddOrUpdate(
                  p => p.Id,
                  new Student { Name = "Andrew Peters" },
                  new Student { Name = "Brice Lambson" },
                  new Student{ Name = "Rowan Miller" }
                );
        }
    }
}
