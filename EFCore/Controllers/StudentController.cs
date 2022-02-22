using EFCore.Models;
using EFCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpGet]
        public List<StudentModel> GetAll()
        {
            return _studentService.GetAll();
        }
        [HttpPost]
        public void Add( StudentModel model)
        {
            _studentService.Add(model);
        }
        [HttpPut]
        public void Update(StudentModel model)
        {
            _studentService.Update(model);
        }
        [HttpDelete]
        public void Delete(int id)
        {
            _studentService.Delete(id);
        }
    }
}
