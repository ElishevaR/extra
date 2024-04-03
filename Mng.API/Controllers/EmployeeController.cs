using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Mng.API.Models;
using Mng.Core;
using Mng.Core.DTOs;
using Mng.Core.Entities;
using Mng.Core.IServices;

namespace Mng.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;

        public EmployeeController(IEmployeeService employeeService,IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            var employees = await _employeeService.GetAllEmployees();
            return Ok(_mapper.Map<IEnumerable<EmployeeDTO>>(employees));
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var employee = await _employeeService.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<EmployeeDTO>(employee));
        }
   [HttpPost]
        [Route("Add_employee")]
        public async Task<IActionResult> CreateEmployee([FromBody] EmployeePostAndPutModel employeePostAndPutModel)
        {
            bool b = await _employeeService.CreateEmployee(_mapper.Map<Employee>(employeePostAndPutModel));
            return Ok(b);
        }

    [HttpDelete("id")]
        public async Task<IActionResult> ChangeEmployeeToNonActivate(int id)
        {
           bool e= await _employeeService.ChangeEmployeeToNonActivate(id);
      if (e)
            return Ok();
      else return BadRequest();
        }
        [HttpPut]
        [Route("id")]
        public async Task<IActionResult> UpdateEmployee(int id, [FromBody] EmployeePostAndPutModel employeePostAndPutModel)
        {
            

            await _employeeService.UpdateEmployee(_mapper.Map<Employee>(employeePostAndPutModel));
            return Ok(employeePostAndPutModel);
        }
    }
}
