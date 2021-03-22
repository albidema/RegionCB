using RegionCB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegionCB.Interfaces
{
    public interface IEmployeeRepository
    {
        void Update(Employee employee);
        Task<bool> SaveAllAsync();
        void Add(Employee employee);
        Task<IEnumerable<Employee>> GetEmployeesAsync();
        Task<Employee> GetUserByIdAsync(int id);
        Task<Employee> GetUserByUsernameAsync(string username);
        Task<List<Employee>> GetMembersAsync();
        Task<Employee> GetMemberAsync(string username);
    }
}
