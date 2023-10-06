using SchoolAPI.Models;
using SchoolAPI.SchoolDbContext;

namespace SchoolAPI.Repositories
{
    public interface ISubjectRepository
    {
        void CreateSubject(Subject subject);
        IEnumerable<Subject> GetAllSubjects();
        Subject GetSubjectById(int subjectId);
        void UpdateSubject(Subject subject, int subjectId);
        void DeleteSubject(int subjectId);
    }
}
