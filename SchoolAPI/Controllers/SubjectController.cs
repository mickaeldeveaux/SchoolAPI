using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Models;
using SchoolAPI.Repositories;

namespace SchoolAPI.Controllers
{
    [Route("subject")]
    [ApiController]
    public class Subjectcontroller : Controller
    {
        private readonly ISubjectRepository _subjectRepostory;

        public Subjectcontroller(ISubjectRepository subjectRepostory)
        {

            _subjectRepostory = subjectRepostory;

        }
        [HttpPost]
        public IActionResult CreateSubject(Subject subject)
        {
            _subjectRepostory.CreateSubject(subject);
            return Ok();
        }
        [HttpGet]
        public ActionResult<IEnumerable<Subject>> GetAll()
        {
            return Ok(_subjectRepostory.GetAllSubjects());
        }
        [HttpGet("{subjectId}")]
        public ActionResult<Subject> GetSubjectId(int subjectId)
        {
            return Ok(_subjectRepostory.GetSubjectById(subjectId));
        }
        [HttpPut("{subjectId}")]
        public IActionResult updateSubject(int subjectId, Subject subject)
        {
            _subjectRepostory.UpdateSubject(subject, subjectId);
            return NoContent();
        }
        [HttpDelete("{subjectId}")]
        public IActionResult DeleteSubject(int subjectId)

        {
            _subjectRepostory.DeleteSubject(subjectId);
            return NoContent();
        }
}
}
