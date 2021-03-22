using Microsoft.EntityFrameworkCore;
using RegionCB.Data;
using RegionCB.Entities;
using RegionCB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegionCB.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly RegionCBContext _context;
        public EmployeeRepository(RegionCBContext context)
        {
            _context = context;
        }

        public Task<Employee> GetMemberAsync(string username)
        {
            throw new NotImplementedException();
        }

        public Task<List<Employee>> GetMembersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetUserByUsernameAsync(string username)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            return await _context.Employee.ToListAsync();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Add(Employee employee)
        {
            _context.Employee.Add(employee);
        }

        public void Update(Employee employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
        }
    }
}
