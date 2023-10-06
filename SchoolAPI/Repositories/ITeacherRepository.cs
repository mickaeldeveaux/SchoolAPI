using SchoolAPI.Filtre;
using SchoolAPI.Models;

namespace SchoolAPI.Repositories
{
    public interface ITeacherRepository
    {
        void CreateTeacher(Teacher teacher);
        IEnumerable<Teacher> GetAllTeacher(TeacherFiltre filtre);
        Teacher GetTeacherById(int teacherId);
        void UpdateTeacher(Teacher teacher, int teacherId);
        void DeleteTeacher(int teacherId);
        IEnumerable<Teacher> GetTeacherByFN(string teacherFN);
    }
}
