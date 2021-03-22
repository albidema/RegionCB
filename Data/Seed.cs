using RegionCB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegionCB.Data
{
    public class Seed
    {
        public static async Task SeedUsers(IEmployeeRepository repo)
        {
            if (await repo.GetEmployeesAsync() != null) return;

            var userData = await System.IO.File.ReadAllTextAsync("Data/employees.csv");
                    
        }
    }
}
