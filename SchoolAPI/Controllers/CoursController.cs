using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Models;
using SchoolAPI.Repositories;

namespace SchoolAPI2.Controllers
{
    [ApiController]
    [Route("cours")]
    public class CoursController : Controller
    {
        private readonly ICoursRepository _coursRepository;
        public CoursController(ICoursRepository coursRepository)
        {
            _coursRepository = coursRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Cours>> GetAll()
        {
            return Ok(_coursRepository.GetAllCours());
        }

        [HttpGet("{coursId}")]
        public ActionResult<Cours> GetCoursById(int coursId)
        {
            return Ok(_coursRepository.GetCoursById(coursId));
        }
        [HttpPut("{coursId}")]
        public IActionResult UpdateCours(int coursId, Cours cours)
        {
            _coursRepository.UpdateCours(cours, coursId);
            return NoContent();
        }
        [HttpDelete("{coursId}")]
        public IActionResult DeleteCours(int coursId)
        {
            _coursRepository.DeleteCours(coursId);
            return NoContent();
        }
        [HttpPost]
        public IActionResult CreateCours(Cours cours)
        {
            _coursRepository.CreateCours(cours);
            return Ok();
        }
    }
}