using Mng.Core.Entities;
using Mng.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mng.Service.Services
{
    public class RoleForEmployeeService : IRoleForEmployeeService
    {
        private readonly IRoleForEmployeeRepository _roleForEmployeeRepsitory;

        public RoleForEmployeeService(IRoleForEmployeeRepository roleForEmployeeRepsitory)
        {
            _roleForEmployeeRepsitory = roleForEmployeeRepsitory;
        }
        public async Task<bool> CreateRoleForEmployee(RoleForEmployee role)
        {
         return  await _roleForEmployeeRepsitory.CreateRoleForEmployee(role);
        }

        public async Task<List<RoleForEmployee>> GetRolesForId(int id)
        {
           return await _roleForEmployeeRepsitory.GetRolesForId(id);
        }
    }
}
