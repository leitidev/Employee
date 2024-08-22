using Employee.Models;
using Employee.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpregadosController : ControllerBase
    {
        private readonly IEmpregadoRepository _empregadoRepository;
        public EmpregadosController(IEmpregadoRepository empregado)
        {
            _empregadoRepository = empregado;
        }
        [HttpGet]
        public async Task<ActionResult<Empregado>> GetEmpregado()
        {
            return Ok();
        }
        [HttpPost]
        public async Task<ActionResult<Empregado>> AddEmpregados(Empregado empregado)
        {
            try
            {
                if (empregado == null) return BadRequest();
                var createEmp = await _empregadoRepository.AddEmpregado(empregado);
                return CreatedAtAction(nameof(GetEmpregado),
                    new { id = createEmp.EmpId }, createEmp);
            }
            catch (Exception ex) {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro");
            }
            return Ok();
        }
    }
}
