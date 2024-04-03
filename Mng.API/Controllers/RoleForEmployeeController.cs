using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Mng.API.Models;
using Mng.Core.DTOs;
using Mng.Core.Entities;
using Mng.Core.IRepositories;
using Mng.Core.IServices;
using Mng.Service.Services;

namespace Mng.API.Controllers
{//דרוש מחיקה-מיותר!!!
    [Route("api/[controller]")]
    [ApiController]
    public class RoleForEmployeeController : ControllerBase
    {
        private readonly IRoleForEmployeeService _roleForEmployeeService;
        private readonly IMapper _mapper;

        public RoleForEmployeeController(IRoleForEmployeeService roleForEmployeeService,IMapper mapper)
        {
            _roleForEmployeeService = roleForEmployeeService;
            _mapper = mapper;
        }
    
        [HttpGet("id")]
        public async Task<IActionResult> GetRolesForEmployee(int id)
        {
            var roles = await _roleForEmployeeService.GetRolesForId(id);
            if (roles == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<IEnumerable<RoleForEmployeeDTO>>(roles));
        }

     
        [HttpPost]
        [Route("Add_role_for_employee")]
        public async Task<IActionResult> CreateEmployee([FromBody] RoleForEmployeeModel roleForEmployeeModel)
        {
            bool b = await _roleForEmployeeService.CreateRoleForEmployee(_mapper.Map<RoleForEmployee>(roleForEmployeeModel));
            return Ok(b);
        }
    }
}
