using SchoolAPI.Models;
using SchoolAPI.SchoolDbContext;

namespace SchoolAPI.Repositories
{
    public class CoursRepository : ICoursRepository
    {
        private readonly SchoolContext _context;
        public CoursRepository(SchoolContext context)
        {
            _context = context;
        }

        public void CreateCours(Cours cours)
        {
            _context.Cours.Add(cours);

            _context.SaveChanges();
        }

        public void DeleteCours(int coursId)
        {
            _context.Cours.Remove(GetCoursById(coursId));

            _context.SaveChanges();
        }

        public IEnumerable<Cours> GetAllCours()
        {
            return _context.Cours.ToList();
        }

        public Cours GetCoursById(int coursId)
        {
            return _context.Cours.Find(coursId);
        }

        public void UpdateCours(Cours cours, int coursId)
        {
            Cours coursentity = GetCoursById(coursId);
            coursentity.DateDebut = cours.DateDebut;
            coursentity.Datefin = cours.Datefin;
            coursentity.SubjectId = cours.SubjectId;
            coursentity.TeacherId = cours.TeacherId;
            _context.Cours.Update(cours);
            _context.SaveChanges();
        }
    }
}
