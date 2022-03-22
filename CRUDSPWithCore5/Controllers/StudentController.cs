using CRUDSPWithCore5.Services;
using CRUDSPWithCore5.Services.IServices;
using CRUDSPWithCore5.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CRUDWithSP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentServices _studentServices;
        public StudentController(IStudentServices studentServices)
        {
            _studentServices = studentServices;
        }

        [HttpGet("GetAllStudent")]
        public IActionResult GetAllStudent()
        {
            var data = _studentServices.GetAllStudent().Select(s => new StudentViewModel
            {
                Id = s.Id,
                StudName = s.StudName,
                Email = s.Email,
                MobileNumber = s.MobileNumber,
                DOB = s.DOB
            });
            return Ok(data);
        }
    }
}
