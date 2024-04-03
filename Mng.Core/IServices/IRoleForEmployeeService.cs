using Mng.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mng.Core.IRepositories
{
    public interface IRoleForEmployeeService
    {
        Task<List<RoleForEmployee>> GetRolesForId(int id);
        Task<bool> CreateRoleForEmployee(RoleForEmployee role);
    }
}
