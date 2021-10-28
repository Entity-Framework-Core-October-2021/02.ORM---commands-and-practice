using _02.Orm___Demo.Models;
using System;
using System.Linq;

namespace _02.Orm___Demo
{
    class Program
    {
        //1.NuGet Packages
        //Microsoft.EntityFrameworkCore.SqlServer
        //Microsoft.EntityFrameworkCore.Design

        //2.Commands in Terminal:
        //dotnet tool install --global dotnet-ef
        //dotnet ef dbcontext scaffold "Server=.;Integrated Security=true;Database=SoftUnii" Microsoft.EntityFrameworkCore.SqlServer -o Models
        static void Main(string[] args)
        {
            var db = new SoftUniiContext();
            Console.WriteLine(db.Employees.Count());

            //db.Towns.Add(new Town { Name = "Pernik" });
            //db.SaveChanges();

            var employees = db.Employees.Where(x => x.FirstName.StartsWith("N"))
                                        .OrderByDescending(x => x.Salary)
                                        .Select(x => new { x.FirstName, x.LastName, x.Salary })
                                        .ToList();

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} => {employee.Salary}");
            }
        }
    }
}
