using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MyFirstMicroServices.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstMicroServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class StudentsController : ControllerBase
    {
       static StudentBO context = new StudentBO();
        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<StudentModel> Get() => context.GetAllStudents();

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public StudentModel Get(int id) => context.GetStudentByid(id);

        // POST api/<StudentsController>
        [HttpPost]
        public void Post([FromBody] StudentModel s) => context.AddStudent(s);

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] StudentModel s) => context.EditStudentById(s, id);

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) => context.DeleteStudentById(id);
    }
}
