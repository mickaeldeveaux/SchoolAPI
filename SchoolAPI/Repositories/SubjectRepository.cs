using SchoolAPI.Models;
using SchoolAPI.SchoolDbContext;

namespace SchoolAPI.Repositories
{

    public class SubjectRepository : ISubjectRepository
    {
        private readonly SchoolContext _context;

        public SubjectRepository(SchoolContext context)
        {
            _context = context;
        }
        public void CreateSubject(Subject subject)
        {
            _context.Subjects.Add(subject);

            _context.SaveChanges();
        }

        public void DeleteSubject(int subjectId)
        {
            _context.Subjects.Remove(GetSubjectById(subjectId));

            _context.SaveChanges(); 
        }

        public IEnumerable<Subject> GetAllSubjects()
        {
            return _context.Subjects.ToList();
        }

        public Subject GetSubjectById(int subjectId)
        {
            return _context.Subjects.Find(subjectId);
        }

        public void UpdateSubject(Subject subject, int subjectId)
        {
            Subject subjecEntity = GetSubjectById(subjectId);
            subjecEntity.Name = subject.Name;
            _context.Subjects.Update(subjecEntity);
            _context.SaveChanges();
        }
    }
}
