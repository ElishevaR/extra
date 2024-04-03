using Microsoft.EntityFrameworkCore;
using Mng.Core.Entities;
using Mng.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mng.Data.Repositories
{
    public class RoleForEmployeeRepository : IRoleForEmployeeRepository

    {
        private readonly DataContext _dataContext;

        public RoleForEmployeeRepository(DataContext context)
        {
            _dataContext = context;
        }
        public async Task<bool> CreateRoleForEmployee(RoleForEmployee role)
        {
            await _dataContext.RoleForEmployee.AddAsync(role);
            await _dataContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<RoleForEmployee>> GetRolesForId(int id)
        {
            return await _dataContext.RoleForEmployee.Where((r)=>r.EmployeeId==id).ToListAsync();
        }
    }
}
