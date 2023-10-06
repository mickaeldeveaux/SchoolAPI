using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Filtre;
using SchoolAPI.Models;
using SchoolAPI.Repositories;

namespace SchoolAPI.Controllers
{
    [Route("teacher")]
    [ApiController]
    public class Teachercontroller : Controller
    {
        private readonly ITeacherRepository _teacherRepostory;

        public Teachercontroller(ITeacherRepository teacherRepostory)
        {

            _teacherRepostory = teacherRepostory;

        }
        [HttpPost]
        public IActionResult CreateTeacher(Teacher teacher)
        {
            _teacherRepostory.CreateTeacher(teacher);
            return Ok();
        }
        [HttpGet]
        public ActionResult<IEnumerable<Teacher>> GetAll([FromQuery] TeacherFiltre filter)
        {
            return Ok(_teacherRepostory.GetAllTeacher(filter));
        }
        [HttpGet("{teacherId}")]
        public ActionResult<Teacher> GetTeacherId(int teacherId)
        {
            return Ok(_teacherRepostory.GetTeacherById(teacherId));
        }
        [HttpPut("{teacherId}")]
        public IActionResult updateTeacher(int teacherId, Teacher teacher)
        {
            _teacherRepostory.UpdateTeacher(teacher, teacherId);
            return NoContent();
        }
        [HttpDelete("{teacherId}")]
        public IActionResult DeleteTeacher(int teacherId)

        {
            _teacherRepostory.DeleteTeacher(teacherId);
            return NoContent();
        }
        [HttpGet("fistname/{teacherFN}")]
        public ActionResult RechercheTeacher(string teacherFN)
        {  
         return Ok(_teacherRepostory.GetTeacherByFN(teacherFN)); 
        }

    }
}
